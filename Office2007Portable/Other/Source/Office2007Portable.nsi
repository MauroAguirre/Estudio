; Copyleft (c) n/a-n/a Azure Zanculmarktum
; You can modify my source, but you can't modify my brain!!

!define BUILDDATE "17 janvier 2014"
!define APPNAME "Microsoft Office 2007"
!define APP "Office2007"
!define APPVER "0.0.0.0"
!define VER "1.8"
!define APPDIR "Office2007"

; === Languages ===
LoadLanguageFile "${NSISDIR}\Contrib\Language files\French.nlf"

; === Program Details ===
Name "${APPNAME} Portable"
OutFile "..\..\${APP}Portable.exe"
Caption "${APPNAME} Portable | PerkedleApps"
VIProductVersion "${APPVER}"
VIAddVersionKey /LANG=${LANG_FRENCH} BuildDate "${BUILDDATE} ${__TIME__}"
VIAddVersionKey /LANG=${LANG_FRENCH} ProductName "${APPNAME} Portable"
VIAddVersionKey /LANG=${LANG_FRENCH} Comments "Allows ${APPNAME} to be run from a removable drive."
VIAddVersionKey /LANG=${LANG_FRENCH} CompanyName "PerkedleApps"
VIAddVersionKey /LANG=${LANG_FRENCH} LegalCopyright "Azure Zanculmarktum"
VIAddVersionKey /LANG=${LANG_FRENCH} FileDescription "${APPNAME} Portable"
VIAddVersionKey /LANG=${LANG_FRENCH} FileVersion "${APPVER}"
VIAddVersionKey /LANG=${LANG_FRENCH} ProductVersion "${VER}"
VIAddVersionKey /LANG=${LANG_FRENCH} InternalName "${APPNAME}"
VIAddVersionKey /LANG=${LANG_FRENCH} LegalTrademarks "PerkedleApps is a Trademark of Azure Zanculmarktum"
VIAddVersionKey /LANG=${LANG_FRENCH} OriginalFilename "${APP}Portable.exe"

; === Runtime Switches ===
XPStyle on
CRCCheck on
WindowIcon off
SilentInstall silent
AutoCloseWindow true
RequestExecutionLevel user

; === Best Compression ===
SetCompress auto
SetCompressor /SOLID lzma
SetCompressorDictSize 32
SetDatablockOptimize on

; === Include ===
!include FileFunc.nsh
!insertmacro GetRoot
!insertmacro GetParent
!insertmacro GetParameters
!include WordFunc.nsh
!insertmacro WordFind
!include LogicLib.nsh
!include Include\Macros.nsh
!include Include\SystemMessageBox.nsh

; === Program Icon ===
Icon "${APP}.ico"

Var ADDITIONALPARAMETERS
Var DISABLESPLASHSCREEN
Var SPLASHSCREENNAME
Var SECONDARYLAUNCH
Var OFFICETEMPLATES
Var USERDEFAULTLANG
Var USEOFFICEMENU
Var ARCHITECTURE
Var USEOFFICETAB
Var SETTINGSDIR
Var DEFAULTDATA
Var RUNTIMEDATA
Var EXECASADMIN
Var PARAMETERS
Var PROGRAMDIR
Var PROGRAMEXE
Var PARENTDIR
Var ROOTDIR
Var BADEXIT
Var UILANG
Var ADDINS
Var LNG

Section "Main"
	; === Get passed parameters ===
	${GetParameters} $PARAMETERS

	; Excel 2007:
	${WordFind} "$PARAMETERS" "-excel" "*" $0
	${If} $0 > "0"
		StrCpy $PROGRAMEXE "EXCEL.EXE"
		Goto CheckRunning
	${EndIf}

	; PowerPoint 2007:
	${WordFind} "$PARAMETERS" "-powerpoint" "*" $0
	${If} $0 > "0"
		StrCpy $PROGRAMEXE "POWERPNT.EXE"
		Goto CheckRunning
	${EndIf}

	; Word 2007:
	${WordFind} "$PARAMETERS" "-word" "*" $0
	${If} $0 > "0"
		StrCpy $PROGRAMEXE "WINWORD.EXE"
		Goto CheckRunning
	${EndIf}

		; === No passed parameters ===
		Goto TheEnd

	CheckRunning:
		System::Call `kernel32::CreateMutexA(i 0, i 0, t "$(^Name)") i .r0 ?e` ; check if launcher is already running
		Pop $0
		StrCmp $0 "0" CheckGoodBadExit
			StrCpy $SECONDARYLAUNCH "true"
			Goto SetDefaultVariables

	CheckGoodBadExit:
		ReadINIStr $0 "$EXEDIR\Data\${APP}PortableRuntimeData.ini" "${APP}Portable" "Status"
		StrCmp $0 "running" "" SetDefaultVariables
			${System::MessageBox} "${MB_OKCANCEL}|${MB_ICONEXCLAMATION}" "Bad exit | PerkedleApps" "Last exit of ${APPNAME} Portable did not restore settings.$\nWould you try to restore local and backup portable settings now?" $0
			StrCmp $0 "1" "" SetDefaultVariables ; if user click OK
				ReadINIStr $0 "$EXEDIR\Data\${APP}PortableRuntimeData.ini" "${APP}Portable" "PluginsDir"
					RMDir "/r" "$0"
				StrCpy $BADEXIT "true"

	SetDefaultVariables:
		System::Call `kernel32::GetCurrentProcess()i.s`
		System::Call `kernel32::IsWow64Process(is,*i.s)`
		Pop $0
		StrCmp $0 "0" "" +2
			StrCpy $ARCHITECTURE "x86"
		StrCmp $0 "1" "" +2
			StrCpy $ARCHITECTURE "x64"

		StrCpy $PROGRAMDIR "$EXEDIR\App\${APPDIR}"
		StrCpy $SETTINGSDIR "$EXEDIR\Data\${APPDIR}"
		StrCpy $DEFAULTDATA "$EXEDIR\App\DefaultData\${APPDIR}"
		${GetRoot} "$EXEDIR" $ROOTDIR
		${GetParent} "$EXEDIR" $PARENTDIR

		; === Read INI parameters ===
		ClearErrors
		ReadINIStr $ADDITIONALPARAMETERS "$EXEDIR\${APP}Portable.ini" "${APP}Portable" "AdditionalParameters"
		IfErrors "" +2
			WriteINIStr "$EXEDIR\${APP}Portable.ini" "${APP}Portable" "AdditionalParameters" ""

		ReadINIStr $EXECASADMIN "$EXEDIR\${APP}Portable.ini" "${APP}Portable" "ExecAsAdmin"
		StrCmp $EXECASADMIN "" "" +2
			WriteINIStr "$EXEDIR\${APP}Portable.ini" "${APP}Portable" "ExecAsAdmin" "false"

		ReadINIStr $DISABLESPLASHSCREEN "$EXEDIR\${APP}Portable.ini" "${APP}Portable" "DisableSplashScreen"
		StrCmp $DISABLESPLASHSCREEN "" "" +2
			WriteINIStr "$EXEDIR\${APP}Portable.ini" "${APP}Portable" "DisableSplashScreen" "false"

		ReadINIStr $SPLASHSCREENNAME "$EXEDIR\${APP}Portable.ini" "${APP}Portable" "SplashScreenName"
		StrCmp $SPLASHSCREENNAME "" "" +2
			WriteINIStr "$EXEDIR\${APP}Portable.ini" "${APP}Portable" "SplashScreenName" ""

		ReadINIStr $ADDINS "$EXEDIR\${APP}Portable.ini" "${APP}Portable" "AddIns"
		StrCmp $ADDINS "" "" +2
			WriteINIStr "$EXEDIR\${APP}Portable.ini" "${APP}Portable" "AddIns" "false"

		ReadINIStr $OFFICETEMPLATES "$EXEDIR\${APP}Portable.ini" "${APP}Portable" "Templates"
		StrCmp $OFFICETEMPLATES "" "" +2
			WriteINIStr "$EXEDIR\${APP}Portable.ini" "${APP}Portable" "Templates" "false"

		ReadINIStr $USERDEFAULTLANG "$EXEDIR\${APP}Portable.ini" "${APP}Portable" "UserDefaultLang"
		StrCmp $USERDEFAULTLANG "" "" +2
			WriteINIStr "$EXEDIR\${APP}Portable.ini" "${APP}Portable" "UserDefaultLang" "true"

		ReadINIStr $UILANG "$EXEDIR\${APP}Portable.ini" "${APP}Portable" "Language"
		StrCmp $UILANG "" "" +2
			WriteINIStr "$EXEDIR\${APP}Portable.ini" "${APP}Portable" "Language" "en-US"

		; Office Tab:
		IfFileExists "$PARENTDIR\CommonFiles\OfficeTab\OfficeTabPortable.exe" "" +4
			CreateDirectory "$EXEDIR\Data"
				WriteINIStr "$EXEDIR\Data\${APP}PortableRuntimeData.ini" "${APP}Portable" "UseOfficeTab" "true"
			ReadINIStr $USEOFFICETAB "$EXEDIR\Data\${APP}PortableRuntimeData.ini" "${APP}Portable" "UseOfficeTab"

		; Office Menu:
		IfFileExists "$PARENTDIR\CommonFiles\OfficeMenu\OfficeMenuPortable.exe" "" +4
			CreateDirectory "$EXEDIR\Data"
				WriteINIStr "$EXEDIR\Data\${APP}PortableRuntimeData.ini" "${APP}Portable" "UseOfficeMenu" "true"
			ReadINIStr $USEOFFICEMENU "$EXEDIR\Data\${APP}PortableRuntimeData.ini" "${APP}Portable" "UseOfficeMenu"

		StrCmp $BADEXIT "true" Close
		StrCmp $SECONDARYLAUNCH "true" GetPassedParameters

	Init:
		; === Backup local registry keys ===
		${registry::BackupLocal} "HKEY_CURRENT_USER\Software\Microsoft\Office"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Office"
		${If} $ARCHITECTURE == "x64"
			SetRegView 64
				${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Office"
			SetRegView 32
		${EndIf}
		${registry::BackupLocal} "HKEY_CURRENT_USER\Software\Microsoft\IMEMIP"
		${registry::BackupLocal} "HKEY_CURRENT_USER\Software\Microsoft\Shared"
		${registry::BackupLocal} "HKEY_CURRENT_USER\Software\Microsoft\Shared Tools"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Shared"
		${If} $ARCHITECTURE == "x64"
			SetRegView 64
				${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Shared"
			SetRegView 32
		${EndIf}
		${registry::BackupLocal} "HKEY_CURRENT_USER\Software\Microsoft\VBA"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VBA"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{88D969E5-F192-11D4-A65F-0040963251E5}"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{88D969E6-F192-11D4-A65F-0040963251E5}"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{88D969E7-F192-11D4-A65F-0040963251E5}"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{88D969E8-F192-11D4-A65F-0040963251E5}"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{88D969E9-F192-11D4-A65F-0040963251E5}"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{88D969EA-F192-11D4-A65F-0040963251E5}"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{88D969EB-F192-11D4-A65F-0040963251E5}"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{88D969EC-8B8B-4C3D-859E-AF6CD158BE0F}"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{88D969EE-F192-11D4-A65F-0040963251E5}"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{88D969EF-F192-11D4-A65F-0040963251E5}"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{88D969F0-F192-11D4-A65F-0040963251E5}"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{88D969F1-F192-11D4-A65F-0040963251E5}"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{88D969F5-F192-11D4-A65F-0040963251E5}"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{00024500-0000-0000-C000-000000000046}"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{7EA9A8FA-F5D2-49E1-99E8-C26EE07FCEEB}"
		${If} $ARCHITECTURE == "x64"
			SetRegView 64
				${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{88D969E5-F192-11D4-A65F-0040963251E5}"
				${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{88D969E6-F192-11D4-A65F-0040963251E5}"
				${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{88D969E7-F192-11D4-A65F-0040963251E5}"
				${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{88D969E8-F192-11D4-A65F-0040963251E5}"
				${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{88D969E9-F192-11D4-A65F-0040963251E5}"
				${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{88D969EA-F192-11D4-A65F-0040963251E5}"
				${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{88D969EB-F192-11D4-A65F-0040963251E5}"
				${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{88D969EC-8B8B-4C3D-859E-AF6CD158BE0F}"
				${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{88D969EE-F192-11D4-A65F-0040963251E5}"
				${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{88D969EF-F192-11D4-A65F-0040963251E5}"
				${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{88D969F0-F192-11D4-A65F-0040963251E5}"
				${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{88D969F1-F192-11D4-A65F-0040963251E5}"
				${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{88D969F5-F192-11D4-A65F-0040963251E5}"
				${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{00024500-0000-0000-C000-000000000046}"
				${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{7EA9A8FA-F5D2-49E1-99E8-C26EE07FCEEB}"
			SetRegView 32
		${EndIf}
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Msxml2.DOMDocument.5.0"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Msxml2.DSOControl.5.0"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Msxml2.FreeThreadedDOMDocument.5.0"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Msxml2.MXDigitalSignature.5.0"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Msxml2.MXHTMLWriter.5.0"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Msxml2.MXNamespaceManager.5.0"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Msxml2.MXXMLWriter.5.0"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Msxml2.SAXAttributes.5.0"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Msxml2.SAXXMLReader.5.0"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Msxml2.ServerXMLHTTP.5.0"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Msxml2.XMLHTTP.5.0"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Msxml2.XMLSchemaCache.5.0"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Msxml2.XSLTemplate.5.0"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Excel.Chart.8"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Installer\Components\029E403DA86A1D115B5B0006799C897E"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Installer\Components\621EAA421190F8740A91708B57BE9969"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Installer\Features\00002109030000000000000000F01FEC"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Installer\Products\00002109030000000000000000F01FEC"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Installer\Products\000021091A0090400000000000F01FEC"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Installer\Products\00002109411090400000000000F01FEC"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Installer\Products\00002109440090400000000000F01FEC"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Installer\Products\00002109510090400000000000F01FEC"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Installer\Products\00002109511090400000000000F01FEC"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Installer\Products\00002109610090400000000000F01FEC"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Installer\Products\00002109711090400000000000F01FEC"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Installer\Products\00002109810090400000000000F01FEC"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Installer\Products\00002109910090400000000000F01FEC"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Installer\Products\00002109A10090400000000000F01FEC"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Installer\Products\00002109AB0090400000000000F01FEC"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Installer\Products\00002109B10090400000000000F01FEC"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Installer\Products\00002109C20090400000000000F01FEC"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Installer\Products\00002109E60090400000000000F01FEC"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Installer\Products\00002109F10090400000000000F01FEC"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Installer\Products\00002109F100A0C00000000000F01FEC"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Installer\Products\00002109F100C0400000000000F01FEC"
		${If} $ARCHITECTURE == "x64"
			SetRegView 64
		${EndIf}
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\11B564CAA807C694ABE73044DC90516B"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\14355655CBD54D944A7518EDDF19EA2D"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\1FA18F7974E099CD0AF18C3B9B1A1EE8"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\1FA18F7974E099CD0BF18C3B9B1A1EE8"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\1FA18F7974E099CD0CF18C3B9B1A1EE8"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\2227A34C816D4F94EB598446F9BD8B17"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\2562336682C91B850AF18C3B9B1A1EE8"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\2562336682C91B850CF18C3B9B1A1EE8"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\2A31EAB9FA7E3C6D0AF18C3B9B1A1EE8"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\2A31EAB9FA7E3C6D0BF18C3B9B1A1EE8"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\2A31EAB9FA7E3C6D0CF18C3B9B1A1EE8"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\2FAFA61ADBF18444690EDB85CAA39EB7"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\337E30A68012B5341B7A8ADE48F4064A"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\379E92CC2CB71D119A12000A9CE1A22A"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\4006F64980E4BACB0DF18C3B9B1A1EE8"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\4006F64980E4BACB0EF18C3B9B1A1EE8"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\47155108894E68A409FDC1FC6E8DA2CB"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\5120EEDE039486F42830D8D2552797F6"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\6C9A6F846E2818A47A408CAF13381C71"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\6EC3DF47D8A2C9E00AF18C3B9B1A1EE8"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\6EC3DF47D8A2C9E00BF18C3B9B1A1EE8"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\6EC3DF47D8A2C9E00CF18C3B9B1A1EE8"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\6F949E36CB3004C50AF18C3B9B1A1EE8"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\6F949E36CB3004C50CF18C3B9B1A1EE8"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\72550EAA4F7970143BF094E2F6C9164E"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\748B2526ADAB4D3429253E7976AF041A"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\77AE531D63D456630DF18C3B9B1A1EE8"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\77ED11277E13FCF4BB8C47FDC65086F1"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\7A562FE20D00C0845B1F640A6D0D0277"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\7AA6F3DBF3CE139469FE63D56E7AF446"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\82DE7549CF3F8CCB0DF18C3B9B1A1EE8"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\9260D47DD05543D43AB5315284107D5B"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\940F43383A1766E44BBD6236980545C5"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\9B905EB838DBFEE4991CF8E66F518BBF"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\9C1D6229422D71045BFB2F8BCE017AA4"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\9D6C7B862FD11C450AF18C3B9B1A1EE8"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\9D6C7B862FD11C450CF18C3B9B1A1EE8"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\A5824C2FB557A5D43881763B7A07D05E"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\AA4747BB0AC53254E8F9B9A7BE7077B9"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\AD4E638E8714C454FA1AD399C0E81909"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\B92D5049E11C93DB0DF18C3B9B1A1EE8"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\C733A8B34D26AF4458B43E09EFC2C77F"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\C89954FBD4FB47C449CE85E9F7E918FB"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\CAB7071E27686994093945B9EE85F69D"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\D94C8360B8BB1DC41B1950E1F8237563"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\D94C8360B8BB1DC41B1950E2F8237563"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\D94C8360B8BB1DC41B1950E3F8237563"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\D94C8360B8BB2DC41B1950E0F8237563"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\DA42BC89BF25F5BD0AF18C3B9B1A1EE8"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\DA42BC89BF25F5BD0BF18C3B9B1A1EE8"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\DA42BC89BF25F5BD0CF18C3B9B1A1EE8"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\E3F997A2790938844ACDF81020B32415"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\F3D0372D14C348850AF18C3B9B1A1EE8"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\F3D0372D14C348850CF18C3B9B1A1EE8"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\F7CD01816C53D32438CF043106011676"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\FE334C41ADDE81149944C1D33967043A"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\9B271454ED4348B47B365F93ADEAC015"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\9D6BD49C8A516ED41BB0C0D31B0F52BC"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\CCABF232126726445BC57F4CDE05C5EB"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\D94C8360B8BB1DC41B1950E0F8237563"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\359E92CC2CB71D119A12000A9CE1A22A"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\8EEF86DD963C1D111A37000A9CA05BF0"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\1C1B74D56F7A1D11A9CC0006794C4E25"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\2EEF86DD963C1D111A37000A9CA05BF0"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\4EEF86DD963C1D111A37000A9CA05BF0"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\A457B2D1A9DC1D112897000CF42C6133"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109030000000000000000F01FEC"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\000021091A0090400000000000F01FEC"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109411090400000000000F01FEC"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109440090400000000000F01FEC"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109510090400000000000F01FEC"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109511090400000000000F01FEC"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109610090400000000000F01FEC"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109711090400000000000F01FEC"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109810090400000000000F01FEC"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109910090400000000000F01FEC"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109A10090400000000000F01FEC"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109AB0090400000000000F01FEC"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109B10090400000000000F01FEC"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109C20090400000000000F01FEC"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109E60090400000000000F01FEC"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109F10090400000000000F01FEC"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109F100A0C00000000000F01FEC"
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109F100C0400000000000F01FEC"
		${If} $ARCHITECTURE == "x64"
			SetRegView 32
		${EndIf}

		; Excel 2007:
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Excel.CSV" # .csv
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\dqyfile" # .dqy
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\.htm\OpenWithList\Excel.exe" # 
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\.htm\OpenWithList\Microsoft Office Excel" # .htm
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\iqyfile" # .iqy
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\.mht\OpenWithList\Excel.exe" # .mht
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\.mht\OpenWithList\Microsoft Office Excel" # .mht
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\odcfile" # .odc
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Excel.SLK" # .slk
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Excel.Addin" # .xla
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Excel.AddInMacroEnabled" # .xlam
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Excel.Backup" # .xlk
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Excel.XLL" # .xll
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Excel.Macrosheet" # .xlm
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Excel.Sheet.8" # .xls
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Excel.SheetBinaryMacroEnabled.12" # .xlsb
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Excelhtmlfile" # .xlshtml
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Excel.SheetMacroEnabled.12" # .xlsm
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Excel.Sheet.12" # .xlsx
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Excel.Template.8" # .xlt
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Excelhtmltemplate" # .xlthtml
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Excel.TemplateMacroEnabled" # .xltm
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Excel.Template" # .xltx
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Excel.Workspace" # .xlw
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Excel.OpenDocumentSpreadsheet.12" # .ods

		; PowerPoint 2007:
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\PowerPoint.Template.8" # .pot
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\powerpointhtmltemplate" # .pothtml
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\PowerPoint.TemplateMacroEnabled.12" # .potm
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\PowerPoint.Template.12" # .potx
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\PowerPoint.Addin.8" # .ppa
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\PowerPoint.Addin.12" # .ppam
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\PowerPoint.SlideShow.8" # .pps
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\PowerPoint.SlideShowMacroEnabled.12" # .ppsm
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\PowerPoint.SlideShow.12" # .ppsx
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\PowerPoint.Show.8" # .ppt
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\powerpointhtmlfile" # .ppthtml
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\PowerPoint.ShowMacroEnabled.12" # .pptm
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\PowerPoint.Show.12" # .pptx
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\powerpointxmlfile" # .pptxml
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\PowerPoint.Wizard.8" # .pwz
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\PowerPoint.SlideMacroEnabled.12" # .sldm
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\PowerPoint.Slide.12" # .sldx
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\OfficeTheme.12" # .thmx
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\PowerPoint.OpenDocumentPresentation.12" # .odp

		; Word 2007:
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Word.Document.8" # .doc
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\wordhtmlfile" # .dochtml
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Word.DocumentMacroEnabled.12" # .docm
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\wordmhtmlfile" # .docmhtml
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Word.Document.12" # .docx
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\wordxmlfile" # .docxml
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Word.Template.8" # .dot
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\wordhtmltemplate" # .dothtml
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Word.TemplateMacroEnabled.12" # .dotm
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Word.Template.12" # .dotx
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\.htm\OpenWithList\Microsoft Office Word" # .htm
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\.htm\OpenWithList\WinWord.exe" # .htm
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\.mht\OpenWithList\Microsoft Office Word" # .mht
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\.mht\OpenWithList\WinWord.exe" # .mht
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Word.RTF.8" # .rtf
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Word.Backup.8" # .wbk
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Word.Wizard.8" # .wiz
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Word.Addin.8" # .wll
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\.xml\OpenWithList\winword.exe" # .xml
		${registry::BackupLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Word.OpenDocumentText.12" # .odt

		; === Refresh shell icons ===
		Delete "$LOCALAPPDATA\IconCache.db"
		System::Call `shell32::SHChangeNotify(i 0x08000000, i 0, i 0, i 0)`

		; === Restore registry key from .reg file ===
		${registry::RestorePortable}

		; === Unregister local libraries ===
		IfFileExists "$COMMONFILES\Microsoft Shared\OFFICE12\MSO.DLL" "" +2
			TypeLib::UnRegister "$COMMONFILES\Microsoft Shared\OFFICE12\MSO.DLL"
		IfFileExists "$COMMONFILES\Microsoft Shared\OFFICE11\msxml5.dll" "" +2
			UnRegDLL "$COMMONFILES\Microsoft Shared\OFFICE11\msxml5.dll"
		IfFileExists "$COMMONFILES\Microsoft Shared\OFFICE12\msoshext.dll" "" +2
			UnRegDLL "$COMMONFILES\Microsoft Shared\OFFICE12\msoshext.dll"
		IfFileExists "$COMMONFILES\Microsoft Shared\OFFICE12\MSOXEV.DLL" "" +2
			UnRegDLL "$COMMONFILES\Microsoft Shared\OFFICE12\MSOXEV.DLL"

		; Excel 2007:
		IfFileExists "$PROGRAMFILES\Microsoft Office\Office12\XL5EN32.OLB" "" +2
			TypeLib::UnRegister "$PROGRAMFILES\Microsoft Office\Office12\XL5EN32.OLB"
		IfFileExists "$PROGRAMFILES\Microsoft Office\Office12\EXCEL.EXE" "" +2
			TypeLib::UnRegister "$PROGRAMFILES\Microsoft Office\Office12\EXCEL.EXE"

		; PowerPoint 2007:
		IfFileExists "$PROGRAMFILES\Microsoft Office\Office12\MSPPT.OLB" "" +2
			TypeLib::UnRegister "$PROGRAMFILES\Microsoft Office\Office12\MSPPT.OLB"

		; Word 2007:
		IfFileExists "$PROGRAMFILES\Microsoft Office\Office12\MSWORD.OLB" "" +2
			TypeLib::UnRegister "$PROGRAMFILES\Microsoft Office\Office12\MSWORD.OLB"

		; Visual Basic for Applications:
		IfFileExists "$SYSDIR\VBAEN32.OLB" "" +2
			TypeLib::UnRegister "$SYSDIR\VBAEN32.OLB"
		IfFileExists "$SYSDIR\VBAEND32.OLB" "" +2
			TypeLib::UnRegister "$SYSDIR\VBAEND32.OLB"
		IfFileExists "$COMMONFILES\Microsoft Shared\VBA\VBA6\VBE6.DLL" "" +2
			TypeLib::UnRegister "$COMMONFILES\Microsoft Shared\VBA\VBA6\VBE6.DLL"
		IfFileExists "$COMMONFILES\Microsoft Shared\VBA\VBA6\VBE6EXT.OLB" "" +2
			TypeLib::UnRegister "$COMMONFILES\Microsoft Shared\VBA\VBA6\VBE6EXT.OLB"
		IfFileExists "$SYSDIR\VEN2232.OLB" "" +2
			TypeLib::UnRegister "$SYSDIR\VEN2232.OLB"

		; AddInDesigner:
		IfFileExists "$COMMONFILES\DESIGNER\MSADDNDR.DLL" "" +2
			UnRegDLL "$COMMONFILES\DESIGNER\MSADDNDR.DLL"

		; === Backup local directories ===
		${directory::BackupLocal} "$APPDATA\Microsoft" "\Office" ; APPDATA for current user "X:\Documents and Settings\%username%\Application Data" (WinXP) "X:\Users\%username%\AppData\Roaming" (Vista, Win7...), also used if LOCALDIR is LOCALAPPDATA
		${directory::BackupLocal} "$LOCALAPPDATA\Microsoft" "\Office"
		${directory::BackupLocalAll} "$APPDATA\Microsoft" "\OFFICE" ; APPDATA for all users "X:\Documents and Settings\All Users\Application Data" (WinXP) "X:\ProgramData" (Vista, Win7...)
		${directory::BackupLocal} "$APPDATA\Microsoft" "\Templates"
		${directory::BackupLocal} "$APPDATA\Microsoft" "\AddIns"
		${directory::BackupLocal} "$APPDATA\Microsoft" "\Proof"
		${directory::BackupLocal} "$APPDATA\Microsoft" "\UProof"
		${directory::BackupLocal} "$APPDATA\Microsoft" "\Excel" ; Excel 2007
		${directory::BackupLocal} "$APPDATA\Microsoft" "\Word" ; Word 2007
		${directory::BackupLocal} "$APPDATA\Microsoft" "\Document Building Blocks" ; Word 2007
		${directory::BackupLocal} "$APPDATA\Microsoft" "\PowerPoint" ; PowerPoint 2007

		; === Restore portable directories ===
		${directory::RestorePortable} "$APPDATA\Microsoft" "\Office" "$SETTINGSDIR\AppData"
		${directory::RestorePortable} "$LOCALAPPDATA\Microsoft" "\Office" "$SETTINGSDIR\LocalAppData"
		${directory::DefaultPortable} "$SETTINGSDIR\AppDataAll" "$DEFAULTDATA" ; import default settings
			${directory::RestorePortableAll} "$APPDATA\Microsoft" "\OFFICE" "$SETTINGSDIR\AppDataAll"

		; === Register portable libraries ===
		TypeLib::Register "$EXEDIR\App\Common\OFFICE12\MSO.DLL"
		RegDLL "$EXEDIR\App\Common\OFFICE11\msxml5.dll"

		; Excel 2007:
		TypeLib::Register "$PROGRAMDIR\XL5EN32.OLB"
		TypeLib::Register "$PROGRAMDIR\EXCEL.EXE"

		; PowerPoint 2007:
		TypeLib::Register "$PROGRAMDIR\MSPPT.OLB"

		; Word 2007:
		TypeLib::Register "$PROGRAMDIR\MSWORD.OLB"

		; Visual Basic for Applications:
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\VBA" "Vbe6DllPath" "$EXEDIR\App\Common\VBA\VBA6\VBE6.DLL"
		WriteRegBin HKEY_LOCAL_MACHINE "SOFTWARE\Classes\Installer\Components\029E403DA86A1D115B5B0006799C897E" "vbe.dll_6.0" "7600550070004100560058002100210021002100210021002100210021004D004B004B0053006B00560042004100460069006C00650073003E005B006C0054005D006A0049007B006A00660028003D00310026004C005B002D00380031002D005D0000000000"
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Classes\Installer\Features\00002109030000000000000000F01FEC" "VBAFiles" ""
		${If} $ARCHITECTURE == "x64"
			SetRegView 64
		${EndIf}
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\1C1B74D56F7A1D11A9CC0006794C4E25" "00002109E60090400000000000F01FEC" "$EXEDIR\App\Common\VBA\VBA6\1033\VBE6INTL.DLL"
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\2EEF86DD963C1D111A37000A9CA05BF0" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\359E92CC2CB71D119A12000A9CE1A22A" "00002109030000000000000000F01FEC" "$EXEDIR\App\Common\VBA\VBA6\VBE6.DLL"
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\4EEF86DD963C1D111A37000A9CA05BF0" "00002109030000000000000000F01FEC" "$EXEDIR\App\Common\VBA\VBA6\VBAME.DLL"
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\A457B2D1A9DC1D112897000CF42C6133" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109030000000000000000F01FEC\Features" "VBAFiles" ""
		${If} $ARCHITECTURE == "x64"
			SetRegView 32
		${EndIf}

		TypeLib::Register "$EXEDIR\App\Common\VBA\VBA6\VBAEN32.OLB"
		TypeLib::Register "$EXEDIR\App\Common\VBA\VBA6\VBAEND32.OLB"
		TypeLib::Register "$EXEDIR\App\Common\VBA\VBA6\VBE6.DLL"
		TypeLib::Register "$EXEDIR\App\Common\VBA\VBA6\VBE6EXT.OLB"
		TypeLib::Register "$EXEDIR\App\Common\VBA\VBA6\VEN2232.OLB"

		; AddInDesigner:
		${If} $ARCHITECTURE == "x64"
			SetRegView 64
		${EndIf}
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\8EEF86DD963C1D111A37000A9CA05BF0" "00002109030000000000000000F01FEC" "$EXEDIR\App\Common\DESIGNER\MSADDNDR.DLL"
		${If} $ARCHITECTURE == "x64"
			SetRegView 32
		${EndIf}

		RegDLL "$EXEDIR\App\Common\DESIGNER\MSADDNDR.DLL"

		; === Copy Visual C++ (if not found) ===
		${vc::CopyLocal} "x86_Microsoft.VC80.CRT_1fc8b3b9a1e18e3b_8.0.50727.762_x-ww_6b128700"
		${vc::CopyLocalPolicies} "x86_policy.8.0.Microsoft.VC80.CRT_1fc8b3b9a1e18e3b_x-ww_77c24773"

		; === Fix annoying message ===
		WriteRegBin HKEY_LOCAL_MACHINE "SOFTWARE\Classes\Installer\Components\621EAA421190F8740A91708B57BE9969" "mso12.dll" "7600550070004100560058002100210021002100210021002100210021004D004B004B0053006B00500072006F006400750063007400460069006C00650073003E00740057007B007E002400340051005D0063004000240021002800530027007800610054004F00350000000000"
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Classes\Installer\Features\00002109030000000000000000F01FEC" "EXCELFiles" "ProductFiles" ; Excel 2007
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Classes\Installer\Features\00002109030000000000000000F01FEC" "PPTFiles" "ProductFiles" ; PowerPoint 2007
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Classes\Installer\Features\00002109030000000000000000F01FEC" "WORDFiles" "ProductFiles" ; Word 2007
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Classes\Installer\Features\00002109030000000000000000F01FEC" "Excel_SP2" "EXCELFiles" ; Excel 2007 SP2
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Classes\Installer\Features\00002109030000000000000000F01FEC" "PowerPoint_SP2" "PPTFiles" ; PowerPoint 2007 SP2
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Classes\Installer\Features\00002109030000000000000000F01FEC" "Word_SP2" "WORDFiles" ; Word 2007 SP2
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Classes\Installer\Features\00002109030000000000000000F01FEC" "ProductFiles" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Classes\Installer\Products\00002109030000000000000000F01FEC" "" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Classes\Installer\Products\000021091A0090400000000000F01FEC" "" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Classes\Installer\Products\00002109411090400000000000F01FEC" "" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Classes\Installer\Products\00002109440090400000000000F01FEC" "" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Classes\Installer\Products\00002109510090400000000000F01FEC" "" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Classes\Installer\Products\00002109511090400000000000F01FEC" "" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Classes\Installer\Products\00002109610090400000000000F01FEC" "" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Classes\Installer\Products\00002109711090400000000000F01FEC" "" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Classes\Installer\Products\00002109810090400000000000F01FEC" "" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Classes\Installer\Products\00002109910090400000000000F01FEC" "" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Classes\Installer\Products\00002109A10090400000000000F01FEC" "" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Classes\Installer\Products\00002109AB0090400000000000F01FEC" "" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Classes\Installer\Products\00002109B10090400000000000F01FEC" "" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Classes\Installer\Products\00002109C20090400000000000F01FEC" "" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Classes\Installer\Products\00002109E60090400000000000F01FEC" "" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Classes\Installer\Products\00002109F10090400000000000F01FEC" "" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Classes\Installer\Products\00002109F100A0C00000000000F01FEC" "" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Classes\Installer\Products\00002109F100C0400000000000F01FEC" "" ""
		${If} $ARCHITECTURE == "x64"
			SetRegView 64
		${EndIf}
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\D94C8360B8BB1DC41B1950E0F8237563" "00002109030000000000000000F01FEC" "$EXEDIR\App\Common\OFFICE12\MSO.DLL"
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\9B271454ED4348B47B365F93ADEAC015" "00002109030000000000000000F01FEC" "$EXEDIR\App\Common\OFFICE12\Cultures\OFFICE.ODF"
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\9D6BD49C8A516ED41BB0C0D31B0F52BC" "00002109030000000000000000F01FEC" "$EXEDIR\App\Common\OFFICE12\MSPTLS.DLL"
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\CCABF232126726445BC57F4CDE05C5EB" "00002109030000000000000000F01FEC" "$EXEDIR\App\Common\OFFICE12\RICHED20.DLL"
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\11B564CAA807C694ABE73044DC90516B" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\14355655CBD54D944A7518EDDF19EA2D" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\1FA18F7974E099CD0AF18C3B9B1A1EE8" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\1FA18F7974E099CD0BF18C3B9B1A1EE8" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\1FA18F7974E099CD0CF18C3B9B1A1EE8" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\2227A34C816D4F94EB598446F9BD8B17" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\2562336682C91B850AF18C3B9B1A1EE8" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\2562336682C91B850CF18C3B9B1A1EE8" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\2A31EAB9FA7E3C6D0AF18C3B9B1A1EE8" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\2A31EAB9FA7E3C6D0BF18C3B9B1A1EE8" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\2A31EAB9FA7E3C6D0CF18C3B9B1A1EE8" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\2FAFA61ADBF18444690EDB85CAA39EB7" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\337E30A68012B5341B7A8ADE48F4064A" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\379E92CC2CB71D119A12000A9CE1A22A" "00000000000000000000000000000000" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\379E92CC2CB71D119A12000A9CE1A22A" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\4006F64980E4BACB0DF18C3B9B1A1EE8" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\4006F64980E4BACB0EF18C3B9B1A1EE8" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\47155108894E68A409FDC1FC6E8DA2CB" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\5120EEDE039486F42830D8D2552797F6" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\6C9A6F846E2818A47A408CAF13381C71" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\6EC3DF47D8A2C9E00AF18C3B9B1A1EE8" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\6EC3DF47D8A2C9E00BF18C3B9B1A1EE8" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\6EC3DF47D8A2C9E00CF18C3B9B1A1EE8" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\6F949E36CB3004C50AF18C3B9B1A1EE8" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\6F949E36CB3004C50CF18C3B9B1A1EE8" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\72550EAA4F7970143BF094E2F6C9164E" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\748B2526ADAB4D3429253E7976AF041A" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\77AE531D63D456630DF18C3B9B1A1EE8" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\77ED11277E13FCF4BB8C47FDC65086F1" "00002109E60090400000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\7A562FE20D00C0845B1F640A6D0D0277" "00002109810090400000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\7AA6F3DBF3CE139469FE63D56E7AF446" "00000000000000000000000000000000" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\7AA6F3DBF3CE139469FE63D56E7AF446" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\82DE7549CF3F8CCB0DF18C3B9B1A1EE8" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\9260D47DD05543D43AB5315284107D5B" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\940F43383A1766E44BBD6236980545C5" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\9B271454ED4348B47B365F93ADEAC015" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\9B905EB838DBFEE4991CF8E66F518BBF" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\9C1D6229422D71045BFB2F8BCE017AA4" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\9D6BD49C8A516ED41BB0C0D31B0F52BC" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\9D6C7B862FD11C450AF18C3B9B1A1EE8" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\9D6C7B862FD11C450CF18C3B9B1A1EE8" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\A5824C2FB557A5D43881763B7A07D05E" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\AA4747BB0AC53254E8F9B9A7BE7077B9" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\AD4E638E8714C454FA1AD399C0E81909" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\B92D5049E11C93DB0DF18C3B9B1A1EE8" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\C733A8B34D26AF4458B43E09EFC2C77F" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\C89954FBD4FB47C449CE85E9F7E918FB" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\CAB7071E27686994093945B9EE85F69D" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\CCABF232126726445BC57F4CDE05C5EB" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\D94C8360B8BB1DC41B1950E1F8237563" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\D94C8360B8BB1DC41B1950E2F8237563" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\D94C8360B8BB1DC41B1950E3F8237563" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\D94C8360B8BB2DC41B1950E0F8237563" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\DA42BC89BF25F5BD0AF18C3B9B1A1EE8" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\DA42BC89BF25F5BD0BF18C3B9B1A1EE8" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\DA42BC89BF25F5BD0CF18C3B9B1A1EE8" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\E3F997A2790938844ACDF81020B32415" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\F3D0372D14C348850AF18C3B9B1A1EE8" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\F3D0372D14C348850CF18C3B9B1A1EE8" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\F7CD01816C53D32438CF043106011676" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\F7CD01816C53D32438CF043106011676" "00002109E60090400000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\FE334C41ADDE81149944C1D33967043A" "00002109030000000000000000F01FEC" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109030000000000000000F01FEC\Features" "EXCELFiles" "" ; Excel 2007
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109030000000000000000F01FEC\Features" "PPTFiles" "" ; PowerPoint 2007
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109030000000000000000F01FEC\Features" "WORDFiles" "" ; Word 2007
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109030000000000000000F01FEC\Features" "Excel_SP2" "" ; Excel 2007 SP2
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109030000000000000000F01FEC\Features" "PowerPoint_SP2" "" ; PowerPoint 2007 SP2
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109030000000000000000F01FEC\Features" "Word_SP2" "" ; Word 2007 SP2
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109030000000000000000F01FEC\Features" "ProductFiles" ""
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109030000000000000000F01FEC\InstallProperties" "LocalPackage" ".msi"
		WriteRegDWORD HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109030000000000000000F01FEC\InstallProperties" "WindowsInstaller" 0x1
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\000021091A0090400000000000F01FEC\InstallProperties" "LocalPackage" ".msi"
		WriteRegDWORD HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\000021091A0090400000000000F01FEC\InstallProperties" "WindowsInstaller" 0x1
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109411090400000000000F01FEC\InstallProperties" "LocalPackage" ".msi"
		WriteRegDWORD HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109411090400000000000F01FEC\InstallProperties" "WindowsInstaller" 0x1
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109440090400000000000F01FEC\InstallProperties" "LocalPackage" ".msi"
		WriteRegDWORD HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109440090400000000000F01FEC\InstallProperties" "WindowsInstaller" 0x1
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109510090400000000000F01FEC\InstallProperties" "LocalPackage" ".msi"
		WriteRegDWORD HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109510090400000000000F01FEC\InstallProperties" "WindowsInstaller" 0x1
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109511090400000000000F01FEC\InstallProperties" "LocalPackage" ".msi"
		WriteRegDWORD HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109511090400000000000F01FEC\InstallProperties" "WindowsInstaller" 0x1
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109610090400000000000F01FEC\InstallProperties" "LocalPackage" ".msi"
		WriteRegDWORD HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109610090400000000000F01FEC\InstallProperties" "WindowsInstaller" 0x1
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109711090400000000000F01FEC\InstallProperties" "LocalPackage" ".msi"
		WriteRegDWORD HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109711090400000000000F01FEC\InstallProperties" "WindowsInstaller" 0x1
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109810090400000000000F01FEC\InstallProperties" "LocalPackage" ".msi"
		WriteRegDWORD HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109810090400000000000F01FEC\InstallProperties" "WindowsInstaller" 0x1
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109910090400000000000F01FEC\InstallProperties" "LocalPackage" ".msi"
		WriteRegDWORD HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109910090400000000000F01FEC\InstallProperties" "WindowsInstaller" 0x1
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109A10090400000000000F01FEC\InstallProperties" "LocalPackage" ".msi"
		WriteRegDWORD HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109A10090400000000000F01FEC\InstallProperties" "WindowsInstaller" 0x1
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109AB0090400000000000F01FEC\InstallProperties" "LocalPackage" ".msi"
		WriteRegDWORD HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109AB0090400000000000F01FEC\InstallProperties" "WindowsInstaller" 0x1
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109B10090400000000000F01FEC\InstallProperties" "LocalPackage" ".msi"
		WriteRegDWORD HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109B10090400000000000F01FEC\InstallProperties" "WindowsInstaller" 0x1
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109C20090400000000000F01FEC\InstallProperties" "LocalPackage" ".msi"
		WriteRegDWORD HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109C20090400000000000F01FEC\InstallProperties" "WindowsInstaller" 0x1
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109E60090400000000000F01FEC\InstallProperties" "LocalPackage" ".msi"
		WriteRegDWORD HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109E60090400000000000F01FEC\InstallProperties" "WindowsInstaller" 0x1
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109F10090400000000000F01FEC\InstallProperties" "LocalPackage" ".msi"
		WriteRegDWORD HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109F10090400000000000F01FEC\InstallProperties" "WindowsInstaller" 0x1
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109F100A0C00000000000F01FEC\InstallProperties" "LocalPackage" ".msi"
		WriteRegDWORD HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109F100A0C00000000000F01FEC\InstallProperties" "WindowsInstaller" 0x1
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109F100C0400000000000F01FEC\InstallProperties" "LocalPackage" ".msi"
		WriteRegDWORD HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109F100C0400000000000F01FEC\InstallProperties" "WindowsInstaller" 0x1
		${If} $ARCHITECTURE == "x64"
			SetRegView 32
		${EndIf}

		; === Set default settings ===
		WriteRegStr HKEY_CURRENT_USER "Software\Microsoft\Office\Common\UserInfo" "UserName" "Azure"
		WriteRegStr HKEY_CURRENT_USER "Software\Microsoft\Office\Common\UserInfo" "UserInitials" "Z"
		${If} $ARCHITECTURE == "x64"
			SetRegView 64
		${EndIf}
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109030000000000000000F01FEC\InstallProperties" "RegCompany" "PerkedleApps"
		${If} $ARCHITECTURE == "x64"
			SetRegView 32
		${EndIf}
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Office\12.0\Registration\{90120000-0030-0000-0000-0000000FF1CE}" "WordName" "Microsoft Word"
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Office\12.0\Registration\{90120000-0030-0000-0000-0000000FF1CE}" "WordNameVersion" "Microsoft® Office Word 2007"
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Office\12.0\Registration\{90120000-0030-0000-0000-0000000FF1CE}" "PowerPointName" "Microsoft PowerPoint"
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Office\12.0\Registration\{90120000-0030-0000-0000-0000000FF1CE}" "PowerPointNameVersion" "Microsoft® Office PowerPoint® 2007"
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Office\12.0\Registration\{90120000-0030-0000-0000-0000000FF1CE}" "ExcelName" "Microsoft Excel"
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Office\12.0\Registration\{90120000-0030-0000-0000-0000000FF1CE}" "ExcelNameVersion" "Microsoft® Office Excel® 2007"
		WriteRegDWORD HKEY_CURRENT_USER "Software\Microsoft\Office\12.0\Common\General" "ShownOptIn" 0x1
		WriteRegDWORD HKEY_CURRENT_USER "Software\Microsoft\Office\12.0\Common\Internet" "UseOnlineContent" 0x0 ; disable Microsoft Office Online
		WriteRegDWORD HKEY_CURRENT_USER "Software\Microsoft\Office\12.0\Excel\Options" "FirstRun" 0x0 ; Excel 2007
		WriteRegDWORD HKEY_CURRENT_USER "Software\Microsoft\Office\12.0\PowerPoint\First Run" "FirstRun" 0x0 ; PowerPoint 2007
		WriteRegDWORD HKEY_CURRENT_USER "Software\Microsoft\Office\12.0\Word\Options" "FirstRun" 0x0 ; Word 2007
		SetShellVarContext all
			WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Office\12.0\Common\General" "Data" "$APPDATA\Microsoft\OFFICE\DATA\OPA12.BAK"
		SetShellVarContext current

		; Fix stdole32.tlb:
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Classes\CLSID\{00024500-0000-0000-C000-000000000046}\LocalServer32" "" "$PROGRAMDIR\$PROGRAMEXE /automation"
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Classes\Excel.Chart.8\protocol\StdFileEditing\server" "" ""

		; Set auto-recover path:
		CreateDirectory "$SETTINGSDIR\AutoRecover"
			WriteRegExpandStr HKEY_CURRENT_USER "Software\Microsoft\Office\12.0\Excel\Options" "AutoRecoverPath" "$SETTINGSDIR\AutoRecover\" ; Excel 2007
			WriteRegExpandStr HKEY_CURRENT_USER "Software\Microsoft\Office\12.0\Word\Options" "AUTOSAVE-PATH" "$SETTINGSDIR\AutoRecover\" ; Word 2007

		; Set default format (used on first run):
		IfFileExists "$SETTINGSDIR\AppData\*.*" PreventHTMLHandler ; check for first run time
			WriteRegDWORD HKEY_CURRENT_USER "Software\Microsoft\Office\12.0\Excel\Options" "DefaultFormat" 0x38 ; .xls (Excel 2007)
			WriteRegDWORD HKEY_CURRENT_USER "Software\Microsoft\Office\12.0\PowerPoint\Options" "DefaultFormat" 0x0 ; .ppt (PowerPoint 2007)
			WriteRegStr HKEY_CURRENT_USER "Software\Microsoft\Office\12.0\Word\Options" "DefaultFormat" "Doc" ; .doc (Word 2007)

	PreventHTMLHandler:
		IfFileExists "$PROGRAMDIR\MSOHEV.DLL" "" +2
			Delete "$PROGRAMDIR\MSOHEV.DLL"
		IfFileExists "$PROGRAMDIR\MSOHEVI.DLL" "" +2
			Delete "$PROGRAMDIR\MSOHEVI.DLL"
		IfFileExists "$PROGRAMDIR\MSOHTMED.EXE" "" AddIns
			Delete "$PROGRAMDIR\MSOHTMED.EXE"

	AddIns:
		StrCmp $ADDINS "true" "" Templates
			SetOutPath "$APPDATA\Microsoft\AddIns"
				CopyFiles /SILENT "$EXEDIR\App\AddIns\*.*" "$APPDATA\Microsoft\AddIns"

	Templates:
		StrCmp $OFFICETEMPLATES "true" "" Medicine
			SetOutPath "$APPDATA\Microsoft\Templates"
				CopyFiles /SILENT "$EXEDIR\App\Templates\*.*" "$APPDATA\Microsoft\Templates"

	Medicine:
		WriteRegBin HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Office\12.0\Registration\{90120000-0030-0000-0000-0000000FF1CE}" "DigitalProductID" "a40000000300000038393338382d3730372d313532383036362d363537303000820000003132332d31323334350000000000000086e554262034eb4eb97a55d6acd7010000000000340ecc518e3862000000000000000000000000000000000000000000000000003332373031000000000000000000000059ee794cf7030000711a000000000000000000000000000000000000000000000000000000000000db7ed978"
		WriteRegStr HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Office\12.0\Registration\{90120000-0030-0000-0000-0000000FF1CE}" "ProductID" "89388-707-1528066-65700"

		; === Office Tab ===
		StrCmp $USEOFFICETAB "true" "" +2
			ExecWait `"$PARENTDIR\CommonFiles\OfficeTab\OfficeTabPortable.exe" -installPortable`

		; === Office Menu ===
		StrCmp $USEOFFICEMENU "true" "" RuntimeData
			ExecWait `"$PARENTDIR\CommonFiles\OfficeMenu\OfficeMenuPortable.exe" -installPortable`

	RuntimeData:
		CreateDirectory "$EXEDIR\Data"
			WriteINIStr "$EXEDIR\Data\${APP}Portable.ini" "${APP}Portable" "LastDrive" "$ROOTDIR" ; store current drive letter
			WriteINIStr "$EXEDIR\Data\${APP}Portable.ini" "${APP}Portable" "LastDirectory" "$EXEDIR" ; store current directory
		SetFileAttributes "$EXEDIR\Data\${APP}Portable.ini" HIDDEN

			WriteINIStr "$EXEDIR\Data\${APP}PortableRuntimeData.ini" "${APP}Portable" "PluginsDir" "$PLUGINSDIR" ; store plugins dir
			WriteINIStr "$EXEDIR\Data\${APP}PortableRuntimeData.ini" "${APP}Portable" "Status" "running" ; store status
		FileOpen $RUNTIMEDATA "$EXEDIR\Data\${APP}PortableRuntimeData.ini" r ; lock file!

		; === Get language ID ===
		System::Call `kernel32::GetUserDefaultLangID() i .r0`

		; === Set LNG variable ===
		StrCmp $0 "1025" "" +2
			StrCpy $LNG "ar-SA" # Arabic
		StrCmp $0 "1026" "" +2
			StrCpy $LNG "bg-BG" # Bulgarian
		StrCmp $0 "1028" "" +2
			StrCpy $LNG "zh-TW" # Chinese (Traditional)
		StrCmp $0 "1029" "" +2
			StrCpy $LNG "cs-CZ" # Czech
		StrCmp $0 "1030" "" +2
			StrCpy $LNG "da-DK" # Danish
		StrCmp $0 "1031" "" +2
			StrCpy $LNG "de-DE" # German
		StrCmp $0 "1032" "" +2
			StrCpy $LNG "el-GR" # Greek
		StrCmp $0 "1033" "" +2
			StrCpy $LNG "en-US" # English
		StrCmp $0 "1034" "" +2
			StrCpy $LNG "es-ES" # Spanish
		StrCmp $0 "1035" "" +2
			StrCpy $LNG "fi-FI" # Finnish
		StrCmp $0 "1036" "" +2
			StrCpy $LNG "fr-FR" # French
		StrCmp $0 "1037" "" +2
			StrCpy $LNG "he-IL" # Hebrew
		StrCmp $0 "1038" "" +2
			StrCpy $LNG "hu-HU" # Hungarian
		StrCmp $0 "1040" "" +2
			StrCpy $LNG "it-IT" # Italian
		StrCmp $0 "1041" "" +2
			StrCpy $LNG "ja-JP" # Japanese
		StrCmp $0 "1042" "" +2
			StrCpy $LNG "ko-KR" # Korean
		StrCmp $0 "1043" "" +2
			StrCpy $LNG "nl-NL" # Dutch
		StrCmp $0 "1044" "" +2
			StrCpy $LNG "nb-NO" # Norwegian (Bokml)
		StrCmp $0 "1045" "" +2
			StrCpy $LNG "pl-PL" # Polish
		StrCmp $0 "1046" "" +2
			StrCpy $LNG "pt-BR" # Portuguese (Brazil)
		StrCmp $0 "1048" "" +2
			StrCpy $LNG "ro-RO" # Romanian
		StrCmp $0 "1049" "" +2
			StrCpy $LNG "ru-RU" # Russian
		StrCmp $0 "1050" "" +2
			StrCpy $LNG "hr-HR" # Croatian
		StrCmp $0 "1051" "" +2
			StrCpy $LNG "sk-SK" # Slovak
		StrCmp $0 "1053" "" +2
			StrCpy $LNG "sv-SE" # Swedish
		StrCmp $0 "1054" "" +2
			StrCpy $LNG "th-TH" # Thai
		StrCmp $0 "1055" "" +2
			StrCpy $LNG "tr-TR" # Turkish
		StrCmp $0 "1058" "" +2
			StrCpy $LNG "uk-UA" # Ukrainian
		StrCmp $0 "1060" "" +2
			StrCpy $LNG "sl-SI" # Slovenian
		StrCmp $0 "1061" "" +2
			StrCpy $LNG "et-EE" # Estonian
		StrCmp $0 "1062" "" +2
			StrCpy $LNG "lv-LV" # Latvian
		StrCmp $0 "1063" "" +2
			StrCpy $LNG "lt-LT" # Lithuanian
		StrCmp $0 "1081" "" +2
			StrCpy $LNG "hi-IN" # Hindi
		StrCmp $0 "1087" "" +2
			StrCpy $LNG "kk-KZ" # Kazakh
		StrCmp $0 "2052" "" +2
			StrCpy $LNG "zh-CN" # Chinese (Simplified)
		StrCmp $0 "2070" "" +2
			StrCpy $LNG "pt-PT" # Portuguese
		StrCmp $0 "3076" "" +2
			StrCpy $LNG "zh-HK" # Chinese (Hong Kong SAR)

		ReadINIStr $USERDEFAULTLANG "$EXEDIR\${APP}Portable.ini" "${APP}Portable" "UserDefaultLang"
		StrCmp $USERDEFAULTLANG "true" CheckLanguage Language

	Language:
		ReadINIStr $UILANG "$EXEDIR\${APP}Portable.ini" "${APP}Portable" "Language"
		StrCpy $LNG "$UILANG"

	CheckLanguage:
		StrCmp $LNG "" "" +2
			StrCpy $LNG "en-US" ; use default language if no supported language on host computer

		; === Check existence of language files ===
		${If} ${FileExists} "$EXEDIR\App\Common\Language\$LNG\ACEINTL.DLL"
		${AndIf} ${FileExists} "$EXEDIR\App\Common\Language\$LNG\ACEWSTR.DLL"
		${AndIf} ${FileExists} "$EXEDIR\App\Common\Language\$LNG\ALRTINTL.DLL"
		${AndIf} ${FileExists} "$EXEDIR\App\Common\Language\$LNG\MSOINTL.DLL"
		${AndIf} ${FileExists} "$EXEDIR\App\Common\Language\$LNG\XLSRVINTL.DLL"
			Goto ChangeLanguage
		${Else}
			${If} ${FileExists} "$EXEDIR\App\Common\OFFICE12\1033\ACEINTL.DLL"
			${AndIf} ${FileExists} "$EXEDIR\App\Common\OFFICE12\1033\ACEWSTR.DLL"
			${AndIf} ${FileExists} "$EXEDIR\App\Common\OFFICE12\1033\ALRTINTL.DLL"
			${AndIf} ${FileExists} "$EXEDIR\App\Common\OFFICE12\1033\MSOINTL.DLL"
			${AndIf} ${FileExists} "$EXEDIR\App\Common\OFFICE12\1033\XLSRVINTL.DLL"
				Goto SplashScreen ; use last used language if language files doesn't exists
			${Else}
				StrCpy $LNG "en-US"
			${EndIf}
		${EndIf}

	ChangeLanguage:
		Delete "$EXEDIR\App\Common\OFFICE12\1033\ACEINTL.DLL"
		Delete "$EXEDIR\App\Common\OFFICE12\1033\ACEWSTR.DLL"
		Delete "$EXEDIR\App\Common\OFFICE12\1033\ALRTINTL.DLL"
		Delete "$EXEDIR\App\Common\OFFICE12\1033\MSOINTL.DLL"
		Delete "$EXEDIR\App\Common\OFFICE12\1033\XLSRVINTL.DLL"
		CopyFiles /SILENT "$EXEDIR\App\Common\Language\$LNG\ACEINTL.DLL" "$EXEDIR\App\Common\OFFICE12\1033"
		CopyFiles /SILENT "$EXEDIR\App\Common\Language\$LNG\ACEWSTR.DLL" "$EXEDIR\App\Common\OFFICE12\1033"
		CopyFiles /SILENT "$EXEDIR\App\Common\Language\$LNG\ALRTINTL.DLL" "$EXEDIR\App\Common\OFFICE12\1033"
		CopyFiles /SILENT "$EXEDIR\App\Common\Language\$LNG\MSOINTL.DLL" "$EXEDIR\App\Common\OFFICE12\1033"
		CopyFiles /SILENT "$EXEDIR\App\Common\Language\$LNG\XLSRVINTL.DLL" "$EXEDIR\App\Common\OFFICE12\1033"

		WriteINIStr "$EXEDIR\${APP}Portable.ini" "${APP}Portable" "Language" "$LNG"

	SplashScreen:
		; Skip splash screen:
		StrCmp $DISABLESPLASHSCREEN "true" GetPassedParameters

		; Custom splash screen:
		StrCmp $SPLASHSCREENNAME "" ShowSplashScreen CustomSplashScreen

	ShowSplashScreen:
		InitPluginsDir
		File "/oname=$PLUGINSDIR\PerkedleApps" "Include\perkedleappssplash.bmp"
		newadvsplash::show /NOUNLOAD 1000 300 200 0xFF00FF /L "$PLUGINSDIR\PerkedleApps"
		Delete "$PLUGINSDIR\PerkedleApps"
		Goto GetPassedParameters

	CustomSplashScreen:
		IfFileExists "$EXEDIR\Data\$SPLASHSCREENNAME.bmp" "" SplashScreen
			newadvsplash::show /NOUNLOAD 1000 300 200 0xFF00FF /L "$EXEDIR\Data\$SPLASHSCREENNAME.bmp"

	GetPassedParameters:
		${GetOptions} "$PARAMETERS" "-parameter" $1

		StrCmp $EXECASADMIN "true" LaunchAsAdmin Launch

	Launch:
		StrCmp $SECONDARYLAUNCH "true" LaunchAndExit
		StdUtils::ExecShellAsUser /NOUNLOAD `"$1" "$ADDITIONALPARAMETERS"` "" "$PROGRAMDIR\$PROGRAMEXE"
		Goto CheckStillRunning

	LaunchAsAdmin:
		; === Launch as administrator privileges ===
		StrCmp $SECONDARYLAUNCH "true" LaunchAsAdminAndExit
		ExecWait `"$PROGRAMDIR\$PROGRAMEXE" "$1" $ADDITIONALPARAMETERS`

	CheckStillRunning:
		; === Wait until app closed ===
		FindProcDLL::WaitProcEnd "EXCEL.EXE" -1 ; Excel 2007
		FindProcDLL::WaitProcEnd "POWERPNT.EXE" -1 ; PowerPoint 2007
		FindProcDLL::WaitProcEnd "WINWORD.EXE" -1 ; Word 2007

		; Excel 2007:
		FindProcDLL::FindProc "EXCEL.EXE"
		StrCmp $R0 "1" "" +3
			Sleep 2000
			Goto CheckStillRunning

		; PowerPoint 2007:
		FindProcDLL::FindProc "POWERPNT.EXE"
		StrCmp $R0 "1" "" +3
			Sleep 2000
			Goto CheckStillRunning

		; Word 2007:
		FindProcDLL::FindProc "WINWORD.EXE"
		StrCmp $R0 "1" "" +3
			Sleep 2000
			Goto CheckStillRunning

	Close:
		; === Office Menu ===
		ReadINIStr $USEOFFICEMENU "$EXEDIR\Data\${APP}PortableRuntimeData.ini" "${APP}Portable" "UseOfficeMenu"
		StrCmp $USEOFFICEMENU "true" "" +2
			ExecWait `"$PARENTDIR\CommonFiles\OfficeMenu\OfficeMenuPortable.exe" -unInstallPortable`

		; === Office Tab ===
		ReadINIStr $USEOFFICETAB "$EXEDIR\Data\${APP}PortableRuntimeData.ini" "${APP}Portable" "UseOfficeTab"
		StrCmp $USEOFFICETAB "true" "" +2
			ExecWait `"$PARENTDIR\CommonFiles\OfficeTab\OfficeTabPortable.exe" -unInstallPortable`

		; === Delete Visual C++ if copied ===
		${vc::DelLocal} "x86_Microsoft.VC80.CRT_1fc8b3b9a1e18e3b_8.0.50727.762_x-ww_6b128700"
		${vc::DelLocalPolicies} "x86_policy.8.0.Microsoft.VC80.CRT_1fc8b3b9a1e18e3b_x-ww_77c24773"

		; === Unregister portable libraries ===
		TypeLib::UnRegister "$EXEDIR\App\Common\OFFICE12\MSO.DLL"
		UnRegDLL "$EXEDIR\App\Common\OFFICE11\msxml5.dl"
			TypeLib::UnRegister "$EXEDIR\App\Common\OFFICE11\msxml5.dll"

		; Excel 2007:
		TypeLib::UnRegister "$PROGRAMDIR\XL5EN32.OLB"
		TypeLib::UnRegister "$PROGRAMDIR\EXCEL.EXE"

		; PowerPoint 2007:
		TypeLib::UnRegister "$PROGRAMDIR\MSPPT.OLB"

		; Word 2007:
		TypeLib::UnRegister "$PROGRAMDIR\MSWORD.OLB"

		; Visual basic for applications:
		TypeLib::UnRegister "$EXEDIR\App\Common\VBA\VBA6\VBAEN32.OLB"
		TypeLib::UnRegister "$EXEDIR\App\Common\VBA\VBA6\VBAEND32.OLB"
		TypeLib::UnRegister "$EXEDIR\App\Common\VBA\VBA6\VBE6.DLL"
		TypeLib::UnRegister "$EXEDIR\App\Common\VBA\VBA6\VBE6EXT.OLB"
		TypeLib::UnRegister "$EXEDIR\App\Common\VBA\VBA6\VEN2232.OLB"

		; AddInDesigner:
		UnRegDLL "$EXEDIR\App\Common\DESIGNER\MSADDNDR.DLL"

		; === Backup portable directories ===
		${directory::BackupPortable} "$SETTINGSDIR\AppData" "$APPDATA\Microsoft" "\Office"
		${directory::BackupPortable} "$SETTINGSDIR\LocalAppData" "$LOCALAPPDATA\Microsoft" "\Office"
		${directory::BackupPortableAll} "$SETTINGSDIR\AppDataAll" "$APPDATA\Microsoft" "\OFFICE"

		; === Restore local directories ===
		${directory::RestoreLocal} "$APPDATA\Microsoft" "\Office"
		${directory::RestoreLocal} "$LOCALAPPDATA\Microsoft" "\Office"
		${directory::RestoreLocalAll} "$APPDATA\Microsoft" "\OFFICE"
		${directory::RestoreLocal} "$APPDATA\Microsoft" "\Templates"
		${directory::RestoreLocal} "$APPDATA\Microsoft" "\AddIns"
		${directory::RestoreLocal} "$APPDATA\Microsoft" "\Proof"
		${directory::RestoreLocal} "$APPDATA\Microsoft" "\UProof"
		${directory::RestoreLocal} "$APPDATA\Microsoft" "\Excel" ; Excel 2007
		${directory::RestoreLocal} "$APPDATA\Microsoft" "\Word" ; Word 2007
		${directory::RestoreLocal} "$APPDATA\Microsoft" "\Document Building Blocks" ; Word 2007
		${directory::RestoreLocal} "$APPDATA\Microsoft" "\PowerPoint" ; PowerPoint 2007

		; === Register local libraries ===
		IfFileExists "$COMMONFILES\Microsoft Shared\OFFICE12\MSO.DLL" "" +2
			TypeLib::Register "$COMMONFILES\Microsoft Shared\OFFICE12\MSO.DLL"
		IfFileExists "$COMMONFILES\Microsoft Shared\OFFICE11\msxml5.dll" "" +2
			RegDLL "$COMMONFILES\Microsoft Shared\OFFICE11\msxml5.dll"
		IfFileExists "$COMMONFILES\Microsoft Shared\OFFICE12\msoshext.dll" "" +2
			RegDLL "$COMMONFILES\Microsoft Shared\OFFICE12\msoshext.dll"
		IfFileExists "$COMMONFILES\Microsoft Shared\OFFICE12\MSOXEV.DLL" "" +2
			RegDLL "$COMMONFILES\Microsoft Shared\OFFICE12\MSOXEV.DLL"

		; Excel 2007:
		IfFileExists "$PROGRAMFILES\Microsoft Office\Office12\XL5EN32.OLB" "" +2
			TypeLib::Register "$PROGRAMFILES\Microsoft Office\Office12\XL5EN32.OLB"
		IfFileExists "$PROGRAMFILES\Microsoft Office\Office12\EXCEL.EXE" "" +2
			TypeLib::Register "$PROGRAMFILES\Microsoft Office\Office12\EXCEL.EXE"

		; PowerPoint 2007:
		IfFileExists "$PROGRAMFILES\Microsoft Office\Office12\MSPPT.OLB" "" +2
			TypeLib::Register "$PROGRAMFILES\Microsoft Office\Office12\MSPPT.OLB"

		; Word 2007:
		IfFileExists "$PROGRAMFILES\Microsoft Office\Office12\MSWORD.OLB" "" +2
			TypeLib::Register "$PROGRAMFILES\Microsoft Office\Office12\MSWORD.OLB"

		; Visual Basic for Applications:
		IfFileExists "$SYSDIR\VBAEN32.OLB" "" +2
			TypeLib::Register "$SYSDIR\VBAEN32.OLB"
		IfFileExists "$SYSDIR\VBAEND32.OLB" "" +2
			TypeLib::Register "$SYSDIR\VBAEND32.OLB"
		IfFileExists "$COMMONFILES\Microsoft Shared\VBA\VBA6\VBE6.DLL" "" +2
			TypeLib::Register "$COMMONFILES\Microsoft Shared\VBA\VBA6\VBE6.DLL"
		IfFileExists "$COMMONFILES\Microsoft Shared\VBA\VBA6\VBE6EXT.OLB" "" +2
			TypeLib::Register "$COMMONFILES\Microsoft Shared\VBA\VBA6\VBE6EXT.OLB"
		IfFileExists "$SYSDIR\VEN2232.OLB" "" +2
			TypeLib::Register "$SYSDIR\VEN2232.OLB"

		; AddInDesigner:
		IfFileExists "$COMMONFILES\DESIGNER\MSADDNDR.DLL" "" +2
			RegDLL "$COMMONFILES\DESIGNER\MSADDNDR.DLL"

		; === Save registry keys to .reg file ===
		Delete "$EXEDIR\Data\${APP}.reg"
		CreateDirectory "$EXEDIR\Data"
			${registry::BackupPortable} "HKEY_CURRENT_USER\Software\Microsoft\Office"

		; === Restore local registry keys ===
		${registry::RestoreLocal} "HKEY_CURRENT_USER\Software\Microsoft\Office"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Office"
		${If} $ARCHITECTURE == "x64"
			SetRegView 64
				${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Office"
			SetRegView 32
		${EndIf}
		${registry::RestoreLocal} "HKEY_CURRENT_USER\Software\Microsoft\IMEMIP"
		${registry::RestoreLocal} "HKEY_CURRENT_USER\Software\Microsoft\Shared"
		${registry::RestoreLocal} "HKEY_CURRENT_USER\Software\Microsoft\Shared Tools"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Shared"
		${If} $ARCHITECTURE == "x64"
			SetRegView 64
				${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Shared"
			SetRegView 32
		${EndIf}
		${registry::RestoreLocal} "HKEY_CURRENT_USER\Software\Microsoft\VBA"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VBA"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{88D969E5-F192-11D4-A65F-0040963251E5}"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{88D969E6-F192-11D4-A65F-0040963251E5}"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{88D969E7-F192-11D4-A65F-0040963251E5}"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{88D969E8-F192-11D4-A65F-0040963251E5}"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{88D969E9-F192-11D4-A65F-0040963251E5}"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{88D969EA-F192-11D4-A65F-0040963251E5}"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{88D969EB-F192-11D4-A65F-0040963251E5}"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{88D969EC-8B8B-4C3D-859E-AF6CD158BE0F}"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{88D969EE-F192-11D4-A65F-0040963251E5}"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{88D969EF-F192-11D4-A65F-0040963251E5}"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{88D969F0-F192-11D4-A65F-0040963251E5}"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{88D969F1-F192-11D4-A65F-0040963251E5}"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{88D969F5-F192-11D4-A65F-0040963251E5}"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{00024500-0000-0000-C000-000000000046}"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{7EA9A8FA-F5D2-49E1-99E8-C26EE07FCEEB}"
		${If} $ARCHITECTURE == "x64"
			SetRegView 64
				${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{88D969E5-F192-11D4-A65F-0040963251E5}"
				${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{88D969E6-F192-11D4-A65F-0040963251E5}"
				${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{88D969E7-F192-11D4-A65F-0040963251E5}"
				${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{88D969E8-F192-11D4-A65F-0040963251E5}"
				${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{88D969E9-F192-11D4-A65F-0040963251E5}"
				${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{88D969EA-F192-11D4-A65F-0040963251E5}"
				${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{88D969EB-F192-11D4-A65F-0040963251E5}"
				${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{88D969EC-8B8B-4C3D-859E-AF6CD158BE0F}"
				${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{88D969EE-F192-11D4-A65F-0040963251E5}"
				${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{88D969EF-F192-11D4-A65F-0040963251E5}"
				${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{88D969F0-F192-11D4-A65F-0040963251E5}"
				${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{88D969F1-F192-11D4-A65F-0040963251E5}"
				${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{88D969F5-F192-11D4-A65F-0040963251E5}"
				${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{00024500-0000-0000-C000-000000000046}"
				${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{7EA9A8FA-F5D2-49E1-99E8-C26EE07FCEEB}"
			SetRegView 32
		${EndIf}
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Msxml2.DOMDocument.5.0"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Msxml2.DSOControl.5.0"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Msxml2.FreeThreadedDOMDocument.5.0"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Msxml2.MXDigitalSignature.5.0"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Msxml2.MXHTMLWriter.5.0"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Msxml2.MXNamespaceManager.5.0"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Msxml2.MXXMLWriter.5.0"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Msxml2.SAXAttributes.5.0"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Msxml2.SAXXMLReader.5.0"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Msxml2.ServerXMLHTTP.5.0"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Msxml2.XMLHTTP.5.0"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Msxml2.XMLSchemaCache.5.0"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Msxml2.XSLTemplate.5.0"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Excel.Chart.8"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Installer\Components\029E403DA86A1D115B5B0006799C897E"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Installer\Components\621EAA421190F8740A91708B57BE9969"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Installer\Features\00002109030000000000000000F01FEC"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Installer\Products\00002109030000000000000000F01FEC"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Installer\Products\000021091A0090400000000000F01FEC"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Installer\Products\00002109411090400000000000F01FEC"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Installer\Products\00002109440090400000000000F01FEC"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Installer\Products\00002109510090400000000000F01FEC"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Installer\Products\00002109511090400000000000F01FEC"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Installer\Products\00002109610090400000000000F01FEC"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Installer\Products\00002109711090400000000000F01FEC"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Installer\Products\00002109810090400000000000F01FEC"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Installer\Products\00002109910090400000000000F01FEC"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Installer\Products\00002109A10090400000000000F01FEC"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Installer\Products\00002109AB0090400000000000F01FEC"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Installer\Products\00002109B10090400000000000F01FEC"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Installer\Products\00002109C20090400000000000F01FEC"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Installer\Products\00002109E60090400000000000F01FEC"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Installer\Products\00002109F10090400000000000F01FEC"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Installer\Products\00002109F100A0C00000000000F01FEC"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Installer\Products\00002109F100C0400000000000F01FEC"
		${If} $ARCHITECTURE == "x64"
			SetRegView 64
		${EndIf}
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\11B564CAA807C694ABE73044DC90516B"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\14355655CBD54D944A7518EDDF19EA2D"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\1FA18F7974E099CD0AF18C3B9B1A1EE8"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\1FA18F7974E099CD0BF18C3B9B1A1EE8"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\1FA18F7974E099CD0CF18C3B9B1A1EE8"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\2227A34C816D4F94EB598446F9BD8B17"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\2562336682C91B850AF18C3B9B1A1EE8"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\2562336682C91B850CF18C3B9B1A1EE8"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\2A31EAB9FA7E3C6D0AF18C3B9B1A1EE8"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\2A31EAB9FA7E3C6D0BF18C3B9B1A1EE8"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\2A31EAB9FA7E3C6D0CF18C3B9B1A1EE8"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\2FAFA61ADBF18444690EDB85CAA39EB7"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\337E30A68012B5341B7A8ADE48F4064A"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\379E92CC2CB71D119A12000A9CE1A22A"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\4006F64980E4BACB0DF18C3B9B1A1EE8"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\4006F64980E4BACB0EF18C3B9B1A1EE8"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\47155108894E68A409FDC1FC6E8DA2CB"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\5120EEDE039486F42830D8D2552797F6"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\6C9A6F846E2818A47A408CAF13381C71"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\6EC3DF47D8A2C9E00AF18C3B9B1A1EE8"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\6EC3DF47D8A2C9E00BF18C3B9B1A1EE8"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\6EC3DF47D8A2C9E00CF18C3B9B1A1EE8"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\6F949E36CB3004C50AF18C3B9B1A1EE8"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\6F949E36CB3004C50CF18C3B9B1A1EE8"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\72550EAA4F7970143BF094E2F6C9164E"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\748B2526ADAB4D3429253E7976AF041A"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\77AE531D63D456630DF18C3B9B1A1EE8"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\77ED11277E13FCF4BB8C47FDC65086F1"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\7A562FE20D00C0845B1F640A6D0D0277"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\7AA6F3DBF3CE139469FE63D56E7AF446"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\82DE7549CF3F8CCB0DF18C3B9B1A1EE8"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\9260D47DD05543D43AB5315284107D5B"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\940F43383A1766E44BBD6236980545C5"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\9B905EB838DBFEE4991CF8E66F518BBF"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\9C1D6229422D71045BFB2F8BCE017AA4"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\9D6C7B862FD11C450AF18C3B9B1A1EE8"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\9D6C7B862FD11C450CF18C3B9B1A1EE8"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\A5824C2FB557A5D43881763B7A07D05E"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\AA4747BB0AC53254E8F9B9A7BE7077B9"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\AD4E638E8714C454FA1AD399C0E81909"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\B92D5049E11C93DB0DF18C3B9B1A1EE8"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\C733A8B34D26AF4458B43E09EFC2C77F"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\C89954FBD4FB47C449CE85E9F7E918FB"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\CAB7071E27686994093945B9EE85F69D"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\D94C8360B8BB1DC41B1950E1F8237563"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\D94C8360B8BB1DC41B1950E2F8237563"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\D94C8360B8BB1DC41B1950E3F8237563"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\D94C8360B8BB2DC41B1950E0F8237563"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\DA42BC89BF25F5BD0AF18C3B9B1A1EE8"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\DA42BC89BF25F5BD0BF18C3B9B1A1EE8"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\DA42BC89BF25F5BD0CF18C3B9B1A1EE8"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\E3F997A2790938844ACDF81020B32415"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\F3D0372D14C348850AF18C3B9B1A1EE8"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\F3D0372D14C348850CF18C3B9B1A1EE8"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\F7CD01816C53D32438CF043106011676"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\FE334C41ADDE81149944C1D33967043A"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\9B271454ED4348B47B365F93ADEAC015"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\9D6BD49C8A516ED41BB0C0D31B0F52BC"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\CCABF232126726445BC57F4CDE05C5EB"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\D94C8360B8BB1DC41B1950E0F8237563"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\359E92CC2CB71D119A12000A9CE1A22A"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\8EEF86DD963C1D111A37000A9CA05BF0"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\1C1B74D56F7A1D11A9CC0006794C4E25"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\2EEF86DD963C1D111A37000A9CA05BF0"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\4EEF86DD963C1D111A37000A9CA05BF0"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Components\A457B2D1A9DC1D112897000CF42C6133"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109030000000000000000F01FEC"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\000021091A0090400000000000F01FEC"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109411090400000000000F01FEC"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109440090400000000000F01FEC"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109510090400000000000F01FEC"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109511090400000000000F01FEC"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109610090400000000000F01FEC"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109711090400000000000F01FEC"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109810090400000000000F01FEC"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109910090400000000000F01FEC"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109A10090400000000000F01FEC"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109AB0090400000000000F01FEC"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109B10090400000000000F01FEC"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109C20090400000000000F01FEC"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109E60090400000000000F01FEC"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109F10090400000000000F01FEC"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109F100A0C00000000000F01FEC"
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\00002109F100C0400000000000F01FEC"
		${If} $ARCHITECTURE == "x64"
			SetRegView 32
		${EndIf}

		; Excel 2007:
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Excel.CSV" # .csv
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\dqyfile" # .dqy
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\.htm\OpenWithList\Excel.exe" # 
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\.htm\OpenWithList\Microsoft Office Excel" # .htm
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\iqyfile" # .iqy
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\.mht\OpenWithList\Excel.exe" # .mht
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\.mht\OpenWithList\Microsoft Office Excel" # .mht
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\odcfile" # .odc
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Excel.SLK" # .slk
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Excel.Addin" # .xla
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Excel.AddInMacroEnabled" # .xlam
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Excel.Restore" # .xlk
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Excel.XLL" # .xll
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Excel.Macrosheet" # .xlm
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Excel.Sheet.8" # .xls
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Excel.SheetBinaryMacroEnabled.12" # .xlsb
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Excelhtmlfile" # .xlshtml
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Excel.SheetMacroEnabled.12" # .xlsm
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Excel.Sheet.12" # .xlsx
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Excel.Template.8" # .xlt
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Excelhtmltemplate" # .xlthtml
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Excel.TemplateMacroEnabled" # .xltm
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Excel.Template" # .xltx
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Excel.Workspace" # .xlw
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Excel.OpenDocumentSpreadsheet.12" # .ods

		; PowerPoint 2007:
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\PowerPoint.Template.8" # .pot
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\powerpointhtmltemplate" # .pothtml
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\PowerPoint.TemplateMacroEnabled.12" # .potm
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\PowerPoint.Template.12" # .potx
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\PowerPoint.Addin.8" # .ppa
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\PowerPoint.Addin.12" # .ppam
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\PowerPoint.SlideShow.8" # .pps
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\PowerPoint.SlideShowMacroEnabled.12" # .ppsm
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\PowerPoint.SlideShow.12" # .ppsx
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\PowerPoint.Show.8" # .ppt
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\powerpointhtmlfile" # .ppthtml
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\PowerPoint.ShowMacroEnabled.12" # .pptm
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\PowerPoint.Show.12" # .pptx
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\powerpointxmlfile" # .pptxml
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\PowerPoint.Wizard.8" # .pwz
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\PowerPoint.SlideMacroEnabled.12" # .sldm
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\PowerPoint.Slide.12" # .sldx
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\OfficeTheme.12" # .thmx
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\PowerPoint.OpenDocumentPresentation.12" # .odp

		; Word 2007:
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Word.Document.8" # .doc
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\wordhtmlfile" # .dochtml
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Word.DocumentMacroEnabled.12" # .docm
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\wordmhtmlfile" # .docmhtml
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Word.Document.12" # .docx
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\wordxmlfile" # .docxml
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Word.Template.8" # .dot
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\wordhtmltemplate" # .dothtml
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Word.TemplateMacroEnabled.12" # .dotm
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Word.Template.12" # .dotx
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\.htm\OpenWithList\Microsoft Office Word" # .htm
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\.htm\OpenWithList\WinWord.exe" # .htm
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\.mht\OpenWithList\Microsoft Office Word" # .mht
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\.mht\OpenWithList\WinWord.exe" # .mht
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Word.RTF.8" # .rtf
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Word.Restore.8" # .wbk
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Word.Wizard.8" # .wiz
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Word.Addin.8" # .wll
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\.xml\OpenWithList\winword.exe" # .xml
		${registry::RestoreLocal} "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Word.OpenDocumentText.12" # .odt

		; === Re-refresh shell icons ===
		Delete "$LOCALAPPDATA\IconCache.db"
		System::Call `shell32::SHChangeNotify(i 0x08000000, i 0, i 0, i 0)`

		; === Restore local and backup portable settings if launcher not closed correctly ===
		StrCmp $BADEXIT "true" "" TheEnd
			StrCpy $BADEXIT ""
			Goto Init

	LaunchAndExit:
		${GetOptions} "$PARAMETERS" "-parameter" $1
		StdUtils::ExecShellAsUser /NOUNLOAD `"$1" "$ADDITIONALPARAMETERS"` "" "$PROGRAMDIR\$PROGRAMEXE"
		Goto TheEnd

	LaunchAsAdminAndExit:
		${GetOptions} "$PARAMETERS" "-parameter" $1
		Exec `"$PROGRAMDIR\$PROGRAMEXE" "$1" $ADDITIONALPARAMETERS`

	TheEnd:
		; === Unload plug-ins ===
		newadvsplash::stop ; unload newadvsplash plug-in
		registry::_Unload ; unload registry plug-in

		; === Remove runtime data ===
		FileClose $RUNTIMEDATA ; unlock file
			Delete "$EXEDIR\Data\${APP}PortableRuntimeData.ini"
SectionEnd