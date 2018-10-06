; Copyleft (c) n/a-n/a Azure Zanculmarktum
; You can modify my source, but you can't modify my brain!!

!define BUILDDATE "14 janvier 2014"
!define APPNAME "Microsoft Office Excel 2007"
!define APP "Excel2007"
!define APPVER "0.0.0.0"
!define VER "1.2"
!define APPEXE "EXCEL.EXE"
!define APPDIR "Office2007"
!define EXECTHIS "Office2007Portable.exe -excel"

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
RequestExecutionLevel admin

; === Best Compression ===
SetCompress auto
SetCompressor /SOLID lzma
SetCompressorDictSize 32
SetDatablockOptimize on

; === Include ===
!include FileFunc.nsh
!insertmacro GetParameters
!include LogicLib.nsh

; === Program Icon ===
Icon "AppIcons\appicon1.ico"

Var PROGRAMDIR
Var PROGRAMEXE
Var EXECSTRING
Var SECONDARYLAUNCH

Section "Main"
	; === Default variables ===
	StrCpy $PROGRAMDIR "$EXEDIR\App\${APPDIR}"
	StrCpy $PROGRAMEXE "${APPEXE}"

	; === Check existence program executable ===
	IfFileExists "$PROGRAMDIR\$PROGRAMEXE" CheckOffice2007Portable
		MessageBox MB_ICONSTOP "Could not find $PROGRAMEXE in $PROGRAMDIR."
		Abort

	CheckOffice2007Portable:
		IfFileExists "$EXEDIR\Office2007Portable.exe" CheckRunning
			MessageBox MB_ICONINFORMATION "Could not find Office2007Portable.exe in $EXEDIR."
			Abort

	CheckRunning:
		FindProcDLL::FindProc "Office2007Portable.exe"
		StrCpy $0 "$R0"
		FindProcDLL::FindProc "$PROGRAMEXE"
		StrCpy $1 "$R0"
		${If} $0 == "1"
		${AndIf} $1 == "1"
			StrCpy $SECONDARYLAUNCH "true"
			StrCpy $EXECSTRING "$PROGRAMDIR\$PROGRAMEXE"
		${EndIf}

		StrCmp $SECONDARYLAUNCH "true" GetPassedParameters

		FindProcDLL::FindProc "$PROGRAMEXE"
		StrCmp $R0 "1" "" GetPassedParameters
			MessageBox MB_ICONINFORMATION "Another instances of ${APPNAME} is already running.$\nPlease close other instances of ${APPNAME} before running ${APPNAME} Portable."
			Abort

	GetPassedParameters:
		; === Get any passed parameters ===
		${GetParameters} $0
		StrCmp "'$0'" "''" "" LaunchProgramParameters

		; === No parameters ===
		StrCmp $SECONDARYLAUNCH "true" "" +7
			ReadINIStr $1 "$EXEDIR\Office2007Portable.ini" "Office2007Portable" "ExecAsAdmin"
			StrCmp $1 "true" +3
				StdUtils::ExecShellAsUser /NOUNLOAD "" "" "$PROGRAMDIR\$PROGRAMEXE"
				Goto TheEnd
			StrCpy $EXECSTRING "$PROGRAMDIR\$PROGRAMEXE"
			Goto LaunchAndExit

		StrCpy $EXECSTRING `${EXECTHIS}`
		Goto LaunchNow

	LaunchProgramParameters:
		StrCmp $SECONDARYLAUNCH "true" "" +7
			ReadINIStr $1 "$EXEDIR\Office2007Portable.ini" "Office2007Portable" "ExecAsAdmin"
			StrCmp $1 "true" +3
				StdUtils::ExecShellAsUser /NOUNLOAD `$0` "" "$PROGRAMDIR\$PROGRAMEXE"
				Goto TheEnd
			StrCpy $EXECSTRING `"$PROGRAMDIR\$PROGRAMEXE" $0`
			Goto LaunchAndExit

		StrCpy $EXECSTRING `${EXECTHIS} -parameter $0`

	LaunchNow:
		Exec $EXECSTRING
		Goto TheEnd

	LaunchAndExit:
		Exec $EXECSTRING

	TheEnd:
SectionEnd