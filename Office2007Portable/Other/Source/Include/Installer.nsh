; === Program Details ===
Name "${APPNAME} Portable"
!ifndef COMMONFILESPLUGIN
	OutFile "..\..\..\${FILENAME}.paf.exe"
!else
	OutFile "..\..\..\..\${FILENAME}.paf.exe"
!endif
!ifndef COMMONFILESPLUGIN
	InstallDir "$EXEDIR\${FOLDER}"
!else
	InstallDir "$EXEDIR"
!endif
Caption "${APPNAME} Portable | PerkedleApps"
VIProductVersion "${APPVER}"
VIAddVersionKey ProductName "${APPNAME} Portable"
!ifdef COMMENTS
	VIAddVersionKey Comments "${COMMENTS}"
!endif
VIAddVersionKey CompanyName "PerkedleApps"
VIAddVersionKey LegalCopyright "PerkedleApps"
VIAddVersionKey FileDescription "${APPNAME} Portable"
VIAddVersionKey FileVersion "${APPVER}"
VIAddVersionKey ProductVersion "${VER}"
VIAddVersionKey InternalName "${APPNAME} Portable"
VIAddVersionKey LegalTrademarks "PerkedleApps is a Trademark of Azure Zanculmarktum"
VIAddVersionKey OriginalFilename "${FILENAME}.paf.exe"

; === Include ===
!include MUI.nsh
!include FileFunc.nsh
!insertmacro GetDrives
!include LogicLib.nsh
!include Include\SystemMessageBox.nsh

; === Runtime Switches ===
CRCCheck on
AutoCloseWindow true
RequestExecutionLevel user
ShowInstDetails nevershow

; === Program Icon ===
Icon "${APP}.ico"
!define MUI_ICON "${APP}.ico"

;=== Icon & Stye ===
BrandingText "PerkedleApps™"

; === Pages ===
!ifdef INPUTBOX | SETUPEXTRACTOR
	Page Custom "InputBoxPageShow" "InputBoxPageLeave"
!endif
!ifdef SETUPEXTRACTOR
	Page Custom "SetupExtractor" "SetupExtractorLeave"
!endif
!define MUI_WELCOMEFINISHPAGE_BITMAP "Include\Installer.bmp"
!ifdef COMPONENTS | MULTILANG
	!define MUI_COMPONENTSPAGE_CHECKBITMAP "Include\Check.bmp"
	!define MUI_COMPONENTSPAGE_NODESC
	!insertmacro MUI_PAGE_COMPONENTS
!endif
!define MUI_DIRECTORYPAGE_VERIFYONLEAVE
!define MUI_PAGE_CUSTOMFUNCTION_LEAVE "LeaveDirectory"
!insertmacro MUI_PAGE_DIRECTORY
!define MUI_PAGE_CUSTOMFUNCTION_SHOW "TaskbarProgress"
!insertmacro MUI_PAGE_INSTFILES
!ifndef COMMONFILESPLUGIN
	!define MUI_FINISHPAGE_TEXT "${APPNAME} Portable has been extracted on your device.\r\n\r\nClick Finish to close this wizard."
	!define MUI_FINISHPAGE_TITLE_3LINES
	!define MUI_FINISHPAGE_RUN
	!define MUI_FINISHPAGE_RUN_TEXT "Open ${APPNAME} Portable folder"
	!define MUI_FINISHPAGE_RUN_NOTCHECKED
	!define MUI_FINISHPAGE_RUN_FUNCTION "OpenInstDir"
	!insertmacro MUI_PAGE_FINISH
!endif

; === Languages ===
!insertmacro MUI_LANGUAGE "English"

Var MAINPATH
Function .onInit
	; === Check if launcher is running ===
	FindProcDLL::FindProc "${LAUNCHER}.exe"
	${If} $R0 == 1
		${System::MessageBox} "${MB_OK}|${MB_ICONINFORMATION}" "${LAUNCHER} is running | PerkedleApps" "Please close all instances of ${LAUNCHER}.  The portable app can not be upgraded while it is running." $0
		Abort
	${EndIf}

	!ifdef INIT
		Call Init
	!endif

	!ifdef MULTILANG
		Call MultiLang
	!endif

	; === Get PortableApps path ===
	${GetDrives} "HDD+FDD" GetDrivesCallBack
	StrCmp $MAINPATH "" +6
		!ifdef COMMONFILESPLUGIN
			StrCpy $INSTDIR "$MAINPATH"
		!else
			StrCpy $INSTDIR "$MAINPATH\${FOLDER}"
		!endif
FunctionEnd

!ifdef INPUTBOX
	Var VER
!endif
!ifdef INPUTBOX | SETUPEXTRACTOR
	Var SKIPINPUTBOX
	Function InputBoxPageShow
		StrCmp $SKIPINPUTBOX "true" +3
			InitPluginsDir
			File "/oname=$PLUGINSDIR\InstallerForm.ini" "Include\InstallerForm.ini"
		!ifdef INPUTBOX
			!insertmacro MUI_HEADER_TEXT "${APPNAME} Version Number" "Enter the Version Number"
			InstallOptions::InitDialog /NOUNLOAD "$PLUGINSDIR\InstallerForm.ini"
			InstallOptions::Show
		!endif
	FunctionEnd

	Function InputBoxPageLeave
		!ifdef INPUTBOX
			; === Check for invalid version number ===
			ReadINIStr $VER "$PLUGINSDIR\InstallerForm.ini" "Field 3" "State"
			StrCmp $VER "" "" +2
				Abort

			StrCpy $SKIPINPUTBOX "true"
		!else
			StrCpy $SKIPINPUTBOX ""
		!endif
	FunctionEnd
!endif

!ifdef SETUPEXTRACTOR
	Var HWND
	Var INPUTFILE
	Var SKIPINPUTFILE
	Var OUTPUTDIR
	Var SKIPOUTPUTDIR
	Var RADIOBUTTON1
	Var RADIOBUTTON2
	Var CHECKRADIOBUTTON
	Var SKIPRADIOBUTTON
	Var FILEREQUEST
	Var DIRREQUEST
	Var INSTALLERTYPE

	Function SetupExtractor
		!insertmacro MUI_HEADER_TEXT "${APPNAME} Setup Extractor" "Select the ${APPNAME} setup to extract."

		nsDialogs::Create 1018
		Pop $HWND

		; === Group box ===
		nsDialogs::CreateControl "BUTTON" "0x40000000|0x10000000|0x04000000|0x00000007" "0x00000020" "0" "77" "100%" "57" "${APPNAME} Setup:"
		nsDialogs::CreateControl "BUTTON" "0x40000000|0x10000000|0x04000000|0x00000007" "0x00000020" "0" "167" "100%" "57" "Save Downloaded ${APPNAME} Setup to:"

		; === Label ===
		nsDialogs::CreateControl "STATIC" "0x40000000|0x10000000|0x04000000|0x00000100" "0x00000020" "0" "0" "100%" "30u" "Setup extractor will extract files from ${APPNAME} setup. Select Offline Installer if you have ${APPNAME} setup, then click Browse to select it. Select Online Installer if you don't have ${APPNAME} setup, and setup extractor will download it."

		; === File request ===
		StrCmp $SKIPINPUTFILE "true" +5
			IfFileExists "$EXEDIR\${SETUPFILE}" "" +2
				StrCpy $INPUTFILE "$EXEDIR\${SETUPFILE}"
			IfFileExists "$EXEDIR\${SETUPFILE}" +2
				StrCpy $INPUTFILE "${SETUPFILE}"
		nsDialogs::CreateControl "BUTTON" "0x40000000|0x10000000|0x04000000|0x00010000" "0" "-108" "98" "90" "24" "Browse..."
		Pop $0
		GetFunctionAddress $1 LocateSetupFile
			nsDialogs::OnClick $0 $1
		nsDialogs::CreateControl "EDIT" "0x40000000|0x10000000|0x04000000|0x00010000|0x00000080|0x00000800" "0x00000100|0x00000200" "15" "101" "315" "20" "$INPUTFILE"
		Pop $FILEREQUEST

		; === Dir request ===
		StrCmp $SKIPOUTPUTDIR "true" +2
			StrCpy $OUTPUTDIR "$EXEDIR"
		nsDialogs::CreateControl "BUTTON" "0x40000000|0x10000000|0x04000000|0x00010000" "0" "-108" "188" "90" "24" "Browse..."
		Pop $0
		GetFunctionAddress $1 SaveSetupFile
			nsDialogs::OnClick $0 $1
		nsDialogs::CreateControl "EDIT" "0x40000000|0x10000000|0x04000000|0x00010000|0x00000080|0x00000800" "0x00000100|0x00000200" "15" "191" "315" "20" "$OUTPUTDIR"
		Pop $DIRREQUEST

		; === Radio button ===
		nsDialogs::CreateControl "BUTTON" "0x40000000|0x10000000|0x04000000|0x00010000|0x00000000|0x00000C00|0x00000009|0x00002000" "0" "0" "60" "100%" "10u" "Offline Installer"
		Pop $RADIOBUTTON1
		nsDialogs::CreateControl "BUTTON" "0x40000000|0x10000000|0x04000000|0x00010000|0x00000000|0x00000C00|0x00000009|0x00002000" "0" "0" "150" "100%" "10u" "Online Installer"
		Pop $RADIOBUTTON2
		GetFunctionAddress $0 SetOfflineInstaller
			nsDialogs::OnClick $RADIOBUTTON1 $0
		GetFunctionAddress $0 SetOnlineInstaller
			nsDialogs::OnClick $RADIOBUTTON2 $0
		StrCmp $SKIPRADIOBUTTON "true" +4
			Call SetOfflineInstaller
			StrCpy $CHECKRADIOBUTTON "$RADIOBUTTON1" ; set first radio button as checked by default
			StrCpy $INSTALLERTYPE "Offline"
		StrCmp $CHECKRADIOBUTTON "RadioButton1" "" +3
			Call SetOfflineInstaller
			StrCpy $CHECKRADIOBUTTON "$RADIOBUTTON1"
		StrCmp $CHECKRADIOBUTTON "RadioButton2" "" +3
			Call SetOnlineInstaller
			StrCpy $CHECKRADIOBUTTON "$RADIOBUTTON2"
		SendMessage $CHECKRADIOBUTTON "0x00F1" "1" "0"

		nsDialogs::Show
	FunctionEnd

	Function LocateSetupFile
		nsDialogs::SelectFileDialog "open" "${SETUPFILE}" "${SETUPFILE}|${SETUPFILE}"
		Pop $0
		StrCmp $0 "" +3
			SendMessage $FILEREQUEST "0x000C" "0" "STR:$0"
			StrCpy $INPUTFILE "$0"
	FunctionEnd

	Function SaveSetupFile
		nsDialogs::SelectFolderDialog "Select the folder to save ${APPNAME} setup in:" "${SETUPFILE}"
		Pop $0
		StrCmp $0 "error" +3
			SendMessage $DIRREQUEST "0x000C" "0" "STR:$0"
			StrCpy $OUTPUTDIR "$0"
	FunctionEnd

	Function SetOfflineInstaller
		; === Show Offline Installer ===
		GetDlgItem $0 $HWND 1200
		ShowWindow $0 1
		GetDlgItem $0 $HWND 1203
		ShowWindow $0 1
		GetDlgItem $0 $HWND 1204
		ShowWindow $0 1

		; === Hide Online Installer ===
		GetDlgItem $0 $HWND 1205
		ShowWindow $0 0
		GetDlgItem $0 $HWND 1206
		ShowWindow $0 0
		GetDlgItem $0 $HWND 1201
		ShowWindow $0 0
	FunctionEnd

	Function SetOnlineInstaller
		; === Hide Offline Installer
		GetDlgItem $0 $HWND 1200
		ShowWindow $0 0
		GetDlgItem $0 $HWND 1203
		ShowWindow $0 0
		GetDlgItem $0 $HWND 1204
		ShowWindow $0 0

		; === Show Online Installer ===
		GetDlgItem $0 $HWND 1205
		ShowWindow $0 1
		GetDlgItem $0 $HWND 1206
		ShowWindow $0 1
		GetDlgItem $0 $HWND 1201
		ShowWindow $0 1
	FunctionEnd

	Function SetupExtractorLeave
		StrCpy $SKIPINPUTFILE "true"
		StrCpy $SKIPOUTPUTDIR "true"

		StrCpy $SKIPRADIOBUTTON "true"
		SendMessage "$RADIOBUTTON1" "0x00F0" "0" "0" $0
		StrCmp "$0" "1" "" +5
			StrCpy $CHECKRADIOBUTTON "RadioButton1"
			StrCpy $INSTALLERTYPE "Offline"
			IfFileExists "$INPUTFILE" +2
				Abort
		SendMessage "$RADIOBUTTON2" "0x00F0" "0" "0" $0
		StrCmp "$0" "1" "" +3
			StrCpy $CHECKRADIOBUTTON "RadioButton2"
			StrCpy $INSTALLERTYPE "Online"
	FunctionEnd
!endif

Function LeaveDirectory
	; === Check for invalid destination directory ===
	GetInstDirError $0
	StrCmp $0 1 "" +2
		Abort

	; Check for Program Files:
	StrCpy $0 "$INSTDIR" 16 # X:\Program Files
	StrCpy $1 "$0" "" 3 # Program Files
	StrCmp $1 "Program Files" "" +2
		Abort
FunctionEnd

Function TaskbarProgress
	w7tbp::Start
FunctionEnd

Function GetDrivesCallBack
	; === Skip usual floppy letters ===
	StrCmp $8 "FDD" "" +7
		StrCmp $9 "A:\" "" +3
			Push $0
			Return
		StrCmp $9 "B:\" "" +3
			Push $0
			Return

	IfFileExists $9PortableApps "" +2
		StrCpy $MAINPATH $9PortableApps

	Push $0
FunctionEnd

Function AppInfo
	!ifdef APPINFO
	!ifndef COMMONFILESPLUGIN
		CreateDirectory "$INSTDIR\App\AppInfo"
		SetOutPath ""
			File "/oname=$INSTDIR\App\AppInfo\appicon.ico" "${APP}.ico"
			File "/oname=$INSTDIR\App\AppInfo\appicon_16.png" "${APP}_16.png"
			File "/oname=$INSTDIR\App\AppInfo\appicon_32.png" "${APP}_32.png"
		SetOutPath "$INSTDIR\App\AppInfo"
			File "Include\appinfo.ini"
		WriteINIStr "$INSTDIR\App\AppInfo\appinfo.ini" "Format" "Type" "PortableApps.comFormat"
		WriteINIStr "$INSTDIR\App\AppInfo\appinfo.ini" "Format" "Version" "0.0"
		WriteINIStr "$INSTDIR\App\AppInfo\appinfo.ini" "Details" "Name" "${APPNAME} Portable"
		WriteINIStr "$INSTDIR\App\AppInfo\appinfo.ini" "Details" "AppID" "${APP}Portable"
		WriteINIStr "$INSTDIR\App\AppInfo\appinfo.ini" "Details" "Publisher" "${PUBLISHER} & PerkedleApps"
		WriteINIStr "$INSTDIR\App\AppInfo\appinfo.ini" "Details" "Homepage" "${HOMEPAGE}"
		WriteINIStr "$INSTDIR\App\AppInfo\appinfo.ini" "Details" "Category" "${CATEGORY}"
		WriteINIStr "$INSTDIR\App\AppInfo\appinfo.ini" "Details" "Description" "${DESCRIPTION}"
		WriteINIStr "$INSTDIR\App\AppInfo\appinfo.ini" "Details" "Language" "${LANGUAGE}"
		WriteINIStr "$INSTDIR\App\AppInfo\appinfo.ini" "License" "Shareable" "true"
		WriteINIStr "$INSTDIR\App\AppInfo\appinfo.ini" "License" "OpenSource" "true"
		WriteINIStr "$INSTDIR\App\AppInfo\appinfo.ini" "License" "Freeware" "true"
		WriteINIStr "$INSTDIR\App\AppInfo\appinfo.ini" "License" "CommercialUse" "true"
		WriteINIStr "$INSTDIR\App\AppInfo\appinfo.ini" "Version" "PackageVersion" "${APPVER}"
		!ifndef INPUTBOX
			WriteINIStr "$INSTDIR\App\AppInfo\appinfo.ini" "Version" "DisplayVersion" "${VER}"
		!else
			WriteINIStr "$INSTDIR\App\AppInfo\appinfo.ini" "Version" "DisplayVersion" "$VER"
		!endif
		WriteINIStr "$INSTDIR\App\AppInfo\appinfo.ini" "Control" "Icons" "1"
		WriteINIStr "$INSTDIR\App\AppInfo\appinfo.ini" "Control" "Start" "${LAUNCHER}.exe"
	!endif
	!endif
FunctionEnd

Function Help
	!ifdef HELP
		!ifndef COMMONFILESPLUGIN
			SetOutPath ""
				File "/oname=$INSTDIR\help.html" "${APP}.html"
			SetOutPath "$INSTDIR\Other\Help"
				File /r /x thumbs.db "Help\*.*"
			SetOutPath "$INSTDIR\Other\Help\images"
				File /r /x thumbs.db "Help\images\*.*"
		!else
			SetOutPath ""
				File "/oname=$INSTDIR\CommonFiles\${APPDIR}\help.html" "${APP}.html"
			SetOutPath "$INSTDIR\CommonFiles\${APPDIR}\Other\Help"
				File /r /x thumbs.db "Help\*.*"
			SetOutPath "$INSTDIR\CommonFiles\${APPDIR}\Other\Help\images"
				File /r /x thumbs.db "Help\images\*.*"
		!endif
	!endif
FunctionEnd

Function Source
	!ifdef SOURCE
		!ifndef COMMONFILESPLUGIN
			SetOutPath "$INSTDIR\Other\Source"
				File /r /x thumbs.db "*.*"
			SetOutPath "$INSTDIR\Other\Source\Include"
				File /r /x thumbs.db "Include\*.*"
		!else
			SetOutPath "$INSTDIR\CommonFiles\${APPDIR}\Other\Source"
				File /r /x thumbs.db "*.*"
			SetOutPath "$INSTDIR\CommonFiles\${APPDIR}\Other\Source\Include"
				File /r /x thumbs.db "Include\*.*"
		!endif
	!endif
FunctionEnd

!ifndef COMMONFILESPLUGIN
	Function OpenInstDir
		ExecShell "Open" "$INSTDIR" ; open installation directory when finished
	FunctionEnd
!endif

Function .onInstSuccess
	; === Refresh PortableApps.com Menu ===
	${GetParent} $INSTDIR $0
	IfFileExists "$0\PortableApps.com\PortableAppsPlatform.exe" "" +11
		; === Send message for the Menu to refresh ===
		FindProcDLL::FindProc "PortableAppsPlatform.exe"
		StrCmp $R0 1 "" +9
			IfFileExists "$0\PortableApps.com\PortableAppsPlatform.exe" "" +4
				StrCpy $1 "PortableApps.comPlatformWindowMessageToRefresh$0\PortableApps.com\PortableAppsPlatform.exe"
				System::Call `user32::RegisterWindowMessage(t r1) i .r2`
				SendMessage 65535 $2 0 0 /TIMEOUT=1
			IfFileExists "$0\PortableApps.com\App\PortableAppsPlatform.exe" "" +4
				StrCpy $1 "PortableApps.comPlatformWindowMessageToRefresh$0\PortableApps.com\App\PortableAppsPlatform.exe"
				System::Call `user32::RegisterWindowMessage(t r1) i .r2`
				SendMessage 65535 $2 0 0 /TIMEOUT=1
FunctionEnd

Function .onInstFailed
	RMDir $INSTDIR ; remove directory if empty
FunctionEnd
