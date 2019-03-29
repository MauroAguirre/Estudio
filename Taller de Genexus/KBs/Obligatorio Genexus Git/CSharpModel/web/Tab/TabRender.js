function Tab($)
{
	var addHistoryPoint = true,
		tabStripSelector = "";

	this.show = function()
	{
		var container = this.getContainerControl(),
			containerId = container.id,
			currentGxClass,
			className = this.Class || "";

		tabStripSelector = '#' + containerId + '_tabs';

		if (!this.IsPostBack)
		{
			if (this.HistoryManagement) {
				HistoryManager.Initialize(this);
			}

			var actx = [];
			for (var i=1; i<=this.PageCount; i++) {
				var ctx = {};
				ctx.index = i;
				ctx.panel = this.getChildContainer("panel" + i);
				ctx.title = this.getChildContainer("title" + i);
				ctx.code = $(ctx.title).contents('div').last().remove().text();
				if (ctx.panel && ctx.title)
					actx.push(ctx);
			}

			try {
				var template = '<ul id="{{containerId}}_tabs" class="nav nav-tabs">'+
									'{{#ctx}}' + 
									'<li>' + 
										'<a id="Tab_{{panel.id}}" href="#{{code}}" data-target="#{{panel.id}}" data-toggle="tab" data-index="{{index}}" data-code="{{code}}">{{title.textContent}}</a>' + 
									'</li>' + 
									'{{/ctx}}'+
								'</ul>' + 
								'<div class="tab-content">'+
									'{{#ctx}}' + 
									'<div class="tab-pane" id="{{panel.id}}"></div>' + 
									'{{/ctx}}' +
								'</div>';
				$(container).append(Mustache.render(template, {
					ctx: actx, 
					containerId: containerId
				}));

				for (var i=0, len=actx.length; i<len; i++) {
					var $tabPane = $("#" + actx[i].panel.id);
					$(actx[i].panel).contents().each(function (i, el) {
						$tabPane[0].appendChild(el);
					});
					actx[i].panel.id = actx[i].panel.id + '_child';
					$tabPane[0].appendChild($(actx[i].panel)[0])
					var $tabItem = $("#Tab_" + actx[i].panel.id);
					$tabItem.data('target', '#' + actx[i].panel.id);
				}

				if (this.ActivePageControlName) {
					this.ActivePage = parseInt($(tabStripSelector).find('li a[data-code="' + this.ActivePageControlName + '"]').attr("data-index"));
				}
				if (!this.ActivePage) {
					this.ActivePage = 1;
				}

				if ($.prototype.tab) {
					this.showActivePage();
				}
				else {
					gx.fx.obs.addObserver('gx.onready', this, this.showActivePage, { single: true });
				}

				var tabUC = this;
				$(tabStripSelector).find('a[data-toggle="tab"]')
					.on('click', function (e) {
						addHistoryPoint = true;
					})
					.on('shown.bs.tab', function (e) {
						tabUC.ActivePage = parseInt($(this).attr("data-index"), 10);
						tabUC.ActivePageControlName = $(this).attr("data-code");
						if (tabUC.HistoryManagement && addHistoryPoint) {
							HistoryManager.AddHistoryPoint(tabUC.ActivePageControlName, true, null, false);
						}
						addHistoryPoint = false;
						if (tabUC.TabChanged) {
							tabUC.TabChanged();
						}
					});
			}
			catch(ex) {
				gx.dbg.write(ex.toString());
			}
		}

		if (gx.lang.gxBoolean(this.Visible)) {
			$(container).show();
		}
		else {
			$(container).hide();
		}

		currentGxClass = $(container).attr('data-gx-class');
		if (currentGxClass) {
			$(container).removeClass(currentGxClass);
		}
		$(container).attr("data-gx-class", className).addClass(className);
	};

	this.showActivePage = function () {
		$(tabStripSelector).find('li:nth-child(' + this.ActivePage + ') a').tab('show');
	};

	// HistoryManager methods ///////////////
	this.getId = function(){
		return (this.ParentObject ? this.ParentObject.CmpContext || "" + "-" + this.ParentObject.ServerClass || "" : "") + "-" + this.ControlName;
	};

	this.urlListener = function(){
		if (gx.grid.drawAtServer)
			return;
		var pageCode = (document.location.hash.length > 0) ? document.location.hash.substr(1) : "";
		if (pageCode) {
			$(tabStripSelector).find('li a[data-code="' + pageCode + '"]').tab('show');
		}
		else {
			addHistoryPoint = false;
			this.SelectTab(1);
		}
	};
	/////////////////////////////////////////

	// Methods
	this.SelectTab = function (i) {
		$(tabStripSelector).find('li:nth-child(' + i +') a').tab('show');
	};

	this.HideTab = function (i) {
		var selector = tabStripSelector + ' li:nth-child(' + i +')';
		$(selector).hide();
		if ($(selector).hasClass('active')) {
			$(tabStripSelector).find('li:visible a').each(function (i, el) {
				$(el).tab('show');
				return false;
			});
		}
	};

	this.ShowTab = function (i) {
		$(tabStripSelector).find('li:nth-child(' + i +')').show();
	};
}
