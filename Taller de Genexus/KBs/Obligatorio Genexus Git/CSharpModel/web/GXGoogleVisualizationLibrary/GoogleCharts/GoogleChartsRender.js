function GoogleCharts() {
	// Databinding for property colors
	this.SetColors = function(data) {
		this.colors = data;
	};

	// Databinding for property colors
	this.GetColors = function() {
		return this.colors;
	};

	// Databinding for property Data
	this.SetData = function(data) {
		this.Data = data;
	};

	// Databinding for property Data
	this.GetData = function() {
		return this.Data;
	};

	var currentType = ""; 

	this.show = function() {
		if (!this.IsPostBack || currentType != this.Type) {
			currentType = this.Type;
			this.loadGoogleChartPackage();
		} else {
			this.RefreshTable();
		}
	};

	var _this = this;

	this.resolvePackage = function() {
		// If the User Agent is IPad or IPhone, always use Core Charts (the new version)
		if (gx.util.browser.isIPad() || gx.util.browser.isIPhone())
			return "corechart";

		// Core charts currently don't support 3D charts, so if 3D is specified, use the old charts.
		if (!CBoolean(this.is3D))
			return "corechart";

		switch (this.Type) {
			case "ColumnChart":
				return "columnchart";
			case "ScatterChart":
				return "scatterchart";
			case "BarChart":
				return (this.Mode == "Interactive") ? "barchart" : "imagebarchart";
			case "LineChart":
				return (this.Mode == "Interactive") ? "linechart" : "imagelinechart";
			case "PieChart":
				return (this.Mode == "Interactive") ? "piechart" : "imagepiechart";
		}

		gx.dbg.logMsg("Google charts: Unknown chart type.");
		return "columnchart";
	};

	this.loadGoogleChartPackage = function() {
		google.load("visualization", "1", { packages: [this.resolvePackage()], callback: function() { _this.showImpl() } });
	};

	this.showImpl = function() {
		this.DrawVisualization();
	};

	this.RefreshTable = function() {
		this.CreateDataTable();
		this.Visualization.draw(this.Data, this.getConfigOptions());

		//selection handler for interactive charts.
		var _this = this;
		if (this.Mode == "Interactive") {
			google.visualization.events.addListener(this.Visualization, 'select', function() { _this.selectHandler() });
		}
	};

	this.selectHandler = function() {
		var selection = this.Visualization.getSelection();
		var item = selection[0];
		if (item) {
			var column = item.column;
			if (typeof (this.Select == 'function')) {
				if ((column === undefined || column === null)&& this.Type == "PieChart") {
					column = 1;
				}
				this.SelectedCategoryName = this.Data.getColumnLabel(column);
				this.SelectedSeriesValue = this.Data.getValue(item.row, column).toFixed(2);
				this.SelectedSeriesName = this.Data.getValue(item.row, 0);
				this.Select();
			}
		}
	};

	this.DrawVisualization = function() {
		this.getContainerControl().style.height = gx.dom.addUnits(this.Height);
		this.getContainerControl().style.width = gx.dom.addUnits(this.Width);
		this.Visualization = this.GetVisualizationControl();
		this.RefreshTable();
	};

	this.getConfigOptions = function() {
		var config = {
			axisColor: this.axisColor.Html,
			backgroundColor: this.backgroundColor.Html,
			focusBorderColor: this.focusBorderColor.Html,
			height: this.Height,
			is3D: CBoolean(this.is3D),
			isStacked: CBoolean(this.isStacked),
			legend: this.legend,
			colors: this.colors || undefined,
			legendBackgroundColor: this.legendBackgroundColor.Html,
			legendTextColor: this.legendTextColor.Html,
			title: this.Title,
			titleColor: this.titleColor.Html,
			width: this.Width
		};

		if (this.resolvePackage() == "corechart") {
			config.reverseCategories = CBoolean(this.reverseAxis);
			config.hAxis = {
				title: this.XTitle
			};
			config.vAxis = {
				title: this.YTitle
			};
		}
		else {
			config.reverseAxis = CBoolean(this.reverseAxis);
			config.titleX = this.XTitle;
			config.titleY = this.YTitle;
		}

		return config;
	};

	function CBoolean(str) {
		if (str) {
			if (typeof (str) == 'string')
				return (str.toLowerCase() == "true")
			return str;
		}
		else
			return false;
	};

	this.GetVisualizationControl = function() {
		var el = this.getContainerControl();
		switch (this.Type) {
			case "ColumnChart":
				return new google.visualization.ColumnChart(el);
			case "ScatterChart":
				return new google.visualization.ScatterChart(el);
			case "BarChart":
				return (this.Mode == "Interactive") ? new google.visualization.BarChart(el) : new google.visualization.ImageBarChart(el);
			case "LineChart":
				return (this.Mode == "Interactive") ? new google.visualization.LineChart(el) : new google.visualization.ImageLineChart(el);
			case "PieChart":
				return (this.Mode == "Interactive") ? new google.visualization.PieChart(el) : new google.visualization.ImagePieChart(el);
			default:
				return new google.visualization.ColumnChart(el);
		}
	};

	this.CreateDataTable = function() {
		var data = new google.visualization.DataTable();
		data.addColumn('string', this.XTitle);
		if (this.Data instanceof Array) // It means Case 2 - Array of numeric , or case 4 - Array of structure
		{
			var row = 0;
			data.addColumn('number', this.XTitle);
			for (var p = 0; this.Data[p] != undefined; p++) {
				// Here we are expecting a collection with a serie of values or names / values or a collection of numbers
				// So the control will take only 1 or 2 properties for each element, the first number and the first string
				var labelAssigned = true;
				var baseName = "";
				data.addRows(1);
				if (isNaN(this.Data[p])) {
					var values = new Array();
					for (var prop in this.Data[p]) {
						var value = parseFloat(this.Data[p][prop]);
						if (!isNaN(value)) {
							values.push({ name: prop, value: value });
						} else {
							baseName = this.Data[p][prop];
						}
					}
					if (values.length == 1) {
						if (baseName == "")
							data.setValue(row, 0, values[0].name);
						else
							data.setValue(row, 0, baseName);
						data.setValue(row, 1, values[0].value);
						row++;
					} else {
						data.addRows(values.length - 1);
						for (var j = 0; values[j] != undefined; j++) {
							data.setValue(row, 0, baseName + " " + values[j].name);
							data.setValue(row, 1, values[j].value);
							row++;
						}
					}
				}
				else { //Case 2 - Array of numeric 
					data.setValue(row, 1, this.Data[p]);
					data.setValue(row, 0, '');
					row++;
				}
			}
		} else {
			if (isNaN(this.Data)) //It means Case 4 - structured or Case 5 - Gxchart structure 
			{
				if (this.Data.Categories != undefined) //  case 5
				{
					//GXchart SDT type
					for (i1 = 0; this.Data.Series[i1] != undefined; i1++) {
						data.addColumn('number', this.Data.Series[i1].Name);
					}
					data.addRows(this.Data.Categories.length);
					if (this.Data != undefined && this.Data.Categories.length > 0) {
						for (j = 0; this.Data.Categories[j] != undefined; j++) {
							data.setValue(j, 0, this.Data.Categories[j]);
							for (x = 1; x <= this.Data.Series.length; x++) {
								data.setValue(j, x, parseFloat(this.Data.Series[x - 1].Values[j]));

							}
						}
					}
				} else { //Case 2: SDT with name and value to show
					for (var prop in this.Data) {
						var value = parseFloat(this.Data[prop]);
						if (isNaN(value)) {
							data.addColumn('number', this.Data[prop]);
							data.addRows(1);
							data.setValue(0, 0, '');
						} else {
							data.setValue(0, 1, value);
						}
					}
				}
			} else { //Case 1 - numeric number to show
				data.addColumn('number', this.XTitle); //this.Title);
				data.addRows(1);
				data.setValue(0, 0, '');
				data.setValue(0, 1, parseFloat(this.Data));
			}
		}
		this.Data = data;
	};

	this.CreateDelegate = function(that, thatMethod) {
		return function() { return thatMethod.call(that); }
	};
}
