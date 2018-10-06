; Copyleft (c) n/a-n/a Azure Zanculmarktum

!define FILENAME    "Office_2007_Portable_${VER}_Rev_1_${APPLANG}"
!define APPNAME     "Microsoft Office 2007 SP3"
!define APP         "Office2007"
!define APPVER      "12.0.6612.1000"
!define VER         "12.0.6612.1000"
!define APPLANG     "Multilingual"
!define FOLDER      "Office2007Portable"
!define LAUNCHER    "Office2007Portable"
!define APPDIR      "Office2007"
!define LANGDIR     "Language"
!define APPINFO
	!define PUBLISHER    "Microsoft Corporation"
	!define HOMEPAGE     "http://www.google.com/search?q=${FILENAME}.paf"
	!define CATEGORY     "Office"
	!define DESCRIPTION  "Manage your entire bussiness"
	!define LANGUAGE     "Multilingual"
!define HELP
!define SOURCE
!define INIT
!define MULTILANG
!define COMPONENTS

; === Best Compression ===
SetCompress Auto
SetCompressor /SOLID lzma
SetCompressorDictSize 32
SetDatablockOptimize On

; === Include ===
!include Include\Installer.nsh

Section "${APPNAME} Portable" Main
	SetDetailsPrint textonly
	DetailPrint "Extracting ${APPNAME} Portable..."
	SetDetailsPrint listonly
	SetDetailsView hide

	SectionIn RO

	SetOutPath "$INSTDIR"
		File "..\..\Office2007Portable.exe"
		File "..\..\Excel2007Portable.exe"
		File "..\..\PowerPoint2007Portable.exe"
		File "..\..\Word2007Portable.exe"
	SetOutPath "$INSTDIR\App\${APPDIR}"
		File /r /x thumbs.db /x MSOHEV.DLL /x MSOHEVI.DLL /x MSOHTMED.EXE "..\..\App\${APPDIR}\*.*"
	SetOutPath "$INSTDIR\App\DefaultData\${APPDIR}"
		File /r /x thumbs.db "..\..\App\DefaultData\${APPDIR}\*.*"
	SetOutPath "$INSTDIR\App\Common"
		File /r /x thumbs.db /x ${LANGDIR} "..\..\App\Common\*.*"
	SetOutPath "$INSTDIR\App\WinSxS"
		File /r /x thumbs.db "..\..\App\WinSxS\*.*"
	SetOutPath "$INSTDIR\App\AddIns"
		File "..\..\App\AddIns\Readme.txt"
	SetOutPath "$INSTDIR\App\Templates"
		File "..\..\App\Templates\Readme.txt"

	Call AppInfo
		SetOutPath "$INSTDIR\App\AppInfo"
			File "AppIcons\*.ico"
			File "AppIcons\*.png"
		WriteINIStr "$INSTDIR\App\AppInfo\appinfo.ini" "Control" "Icons" "3"
		DeleteINIStr "$INSTDIR\App\AppInfo\appinfo.ini" "Control" "Start"
		WriteINIStr "$INSTDIR\App\AppInfo\appinfo.ini" "Control" "Start1" "Excel2007Portable.exe"
		WriteINIStr "$INSTDIR\App\AppInfo\appinfo.ini" "Control" "Name1" "Microsoft Office Excel 2007 Portable"
		WriteINIStr "$INSTDIR\App\AppInfo\appinfo.ini" "Control" "Start2" "PowerPoint2007Portable.exe"
		WriteINIStr "$INSTDIR\App\AppInfo\appinfo.ini" "Control" "Name2" "Microsoft Office PowerPoint 2007 Portable"
		WriteINIStr "$INSTDIR\App\AppInfo\appinfo.ini" "Control" "Start3" "Word2007Portable.exe"
		WriteINIStr "$INSTDIR\App\AppInfo\appinfo.ini" "Control" "Name3" "Microsoft Office Word 2007 Portable"

	Call Help

	Call Source
SectionEnd

!ifdef MULTILANG
	SectionGroup "Language"
		Section /o "Arabic" ar-SA
			SetOutPath "$INSTDIR\App\Common\Language\ar-SA"
				File /r /x thumbs.db "..\..\App\Common\Language\ar-SA\*.*"
		SectionEnd
		Section /o "Bulgarian" bg-BG
			SetOutPath "$INSTDIR\App\Common\Language\bg-BG"
				File /r /x thumbs.db "..\..\App\Common\Language\bg-BG\*.*"
		SectionEnd
		Section /o "Chinese (Hong Kong SAR)" zh-HK
			SetOutPath "$INSTDIR\App\Common\Language\zh-HK"
				File /r /x thumbs.db "..\..\App\Common\Language\zh-HK\*.*"
		SectionEnd
		Section /o "Chinese (Simplified)" zh-CN
			SetOutPath "$INSTDIR\App\Common\Language\zh-CN"
				File /r /x thumbs.db "..\..\App\Common\Language\zh-CN\*.*"
		SectionEnd
		Section /o "Chinese (Traditional)" zh-TW
			SetOutPath "$INSTDIR\App\Common\Language\zh-TW"
				File /r /x thumbs.db "..\..\App\Common\Language\zh-TW\*.*"
		SectionEnd
		Section /o "Croatian" hr-HR
			SetOutPath "$INSTDIR\App\Common\Language\hr-HR"
				File /r /x thumbs.db "..\..\App\Common\Language\hr-HR\*.*"
		SectionEnd
		Section /o "Czech" cs-CZ
			SetOutPath "$INSTDIR\App\Common\Language\cs-CZ"
				File /r /x thumbs.db "..\..\App\Common\Language\cs-CZ\*.*"
		SectionEnd
		Section /o "Danish" da-DK
			SetOutPath "$INSTDIR\App\Common\Language\da-DK"
				File /r /x thumbs.db "..\..\App\Common\Language\da-DK\*.*"
		SectionEnd
		Section /o "Dutch" nl-NL
			SetOutPath "$INSTDIR\App\Common\Language\nl-NL"
				File /r /x thumbs.db "..\..\App\Common\Language\nl-NL\*.*"
		SectionEnd
		Section "English" en-US ; selected by default
			SectionIn RO        ; user cannot change
			SetOutPath "$INSTDIR\App\Common\Language\en-US"
				File /r /x thumbs.db "..\..\App\Common\Language\en-US\*.*"
		SectionEnd
		Section /o "Estonian" et-EE
			SetOutPath "$INSTDIR\App\Common\Language\et-EE"
				File /r /x thumbs.db "..\..\App\Common\Language\et-EE\*.*"
		SectionEnd
		Section /o "Finnish" fi-FI
			SetOutPath "$INSTDIR\App\Common\Language\fi-FI"
				File /r /x thumbs.db "..\..\App\Common\Language\fi-FI\*.*"
		SectionEnd
		Section /o "French" fr-FR
			SetOutPath "$INSTDIR\App\Common\Language\fr-FR"
				File /r /x thumbs.db "..\..\App\Common\Language\fr-FR\*.*"
		SectionEnd
		Section /o "German" de-DE
			SetOutPath "$INSTDIR\App\Common\Language\de-DE"
				File /r /x thumbs.db "..\..\App\Common\Language\de-DE\*.*"
		SectionEnd
		Section /o "Greek" el-GR
			SetOutPath "$INSTDIR\App\Common\Language\el-GR"
				File /r /x thumbs.db "..\..\App\Common\Language\el-GR\*.*"
		SectionEnd
		Section /o "Hebrew" he-IL
			SetOutPath "$INSTDIR\App\Common\Language\he-IL"
				File /r /x thumbs.db "..\..\App\Common\Language\he-IL\*.*"
		SectionEnd
		Section /o "Hindi" hi-IN
			SetOutPath "$INSTDIR\App\Common\Language\hi-IN"
				File /r /x thumbs.db "..\..\App\Common\Language\hi-IN\*.*"
		SectionEnd
		Section /o "Hungarian" hu-HU
			SetOutPath "$INSTDIR\App\Common\Language\hu-HU"
				File /r /x thumbs.db "..\..\App\Common\Language\hu-HU\*.*"
		SectionEnd
		Section /o "Italian" it-IT
			SetOutPath "$INSTDIR\App\Common\Language\it-IT"
				File /r /x thumbs.db "..\..\App\Common\Language\it-IT\*.*"
		SectionEnd
		Section /o "Japanese" ja-JP
			SetOutPath "$INSTDIR\App\Common\Language\ja-JP"
				File /r /x thumbs.db "..\..\App\Common\Language\ja-JP\*.*"
		SectionEnd
		Section /o "Kazakh" kk-KZ
			SetOutPath "$INSTDIR\App\Common\Language\kk-KZ"
				File /r /x thumbs.db "..\..\App\Common\Language\kk-KZ\*.*"
		SectionEnd
		Section /o "Korean" ko-KR
			SetOutPath "$INSTDIR\App\Common\Language\ko-KR"
				File /r /x thumbs.db "..\..\App\Common\Language\ko-KR\*.*"
		SectionEnd
		Section /o "Latvian" lv-LV
			SetOutPath "$INSTDIR\App\Common\Language\lv-LV"
				File /r /x thumbs.db "..\..\App\Common\Language\lv-LV\*.*"
		SectionEnd
		Section /o "Lithuanian" lt-LT
			SetOutPath "$INSTDIR\App\Common\Language\lt-LT"
				File /r /x thumbs.db "..\..\App\Common\Language\lt-LT\*.*"
		SectionEnd
		Section /o "Norwegian (Bokml)" nb-NO
			SetOutPath "$INSTDIR\App\Common\Language\nb-NO"
				File /r /x thumbs.db "..\..\App\Common\Language\nb-NO\*.*"
		SectionEnd
		Section /o "Polish" pl-PL
			SetOutPath "$INSTDIR\App\Common\Language\pl-PL"
				File /r /x thumbs.db "..\..\App\Common\Language\pl-PL\*.*"
		SectionEnd
		Section /o "Portuguese" pt-PT
			SetOutPath "$INSTDIR\App\Common\Language\pt-PT"
				File /r /x thumbs.db "..\..\App\Common\Language\pt-PT\*.*"
		SectionEnd
		Section /o "Portuguese (Brazil)" pt-BR
			SetOutPath "$INSTDIR\App\Common\Language\pt-BR"
				File /r /x thumbs.db "..\..\App\Common\Language\pt-BR\*.*"
		SectionEnd
		Section /o "Romanian" ro-RO
			SetOutPath "$INSTDIR\App\Common\Language\ro-RO"
				File /r /x thumbs.db "..\..\App\Common\Language\ro-RO\*.*"
		SectionEnd
		Section /o "Russian" ru-RU
			SetOutPath "$INSTDIR\App\Common\Language\ru-RU"
				File /r /x thumbs.db "..\..\App\Common\Language\ru-RU\*.*"
		SectionEnd
		Section /o "Slovak" sk-SK
			SetOutPath "$INSTDIR\App\Common\Language\sk-SK"
				File /r /x thumbs.db "..\..\App\Common\Language\sk-SK\*.*"
		SectionEnd
		Section /o "Spanish" es-ES
			SetOutPath "$INSTDIR\App\Common\Language\es-ES"
				File /r /x thumbs.db "..\..\App\Common\Language\es-ES\*.*"
		SectionEnd
		Section /o "Slovenian" sl-SI
			SetOutPath "$INSTDIR\App\Common\Language\sl-SI"
				File /r /x thumbs.db "..\..\App\Common\Language\sl-SI\*.*"
		SectionEnd
		Section /o "Swedish" sv-SE
			SetOutPath "$INSTDIR\App\Common\Language\sv-SE"
				File /r /x thumbs.db "..\..\App\Common\Language\sv-SE\*.*"
		SectionEnd
		Section /o "Thai" th-TH
			SetOutPath "$INSTDIR\App\Common\Language\th-TH"
				File /r /x thumbs.db "..\..\App\Common\Language\th-TH\*.*"
		SectionEnd
		Section /o "Turkish" tr-TR
			SetOutPath "$INSTDIR\App\Common\Language\tr-TR"
				File /r /x thumbs.db "..\..\App\Common\Language\tr-TR\*.*"
		SectionEnd
		Section /o "Ukrainian" uk-UA
			SetOutPath "$INSTDIR\App\Common\Language\uk-UA"
				File /r /x thumbs.db "..\..\App\Common\Language\uk-UA\*.*"
		SectionEnd
	SectionGroupEnd

	Function MultiLang
		; === Automatically select language with the same language of Windows language ===
		System::Call `kernel32::GetUserDefaultLangID() i .r0`
		StrCmp $0 "1025" "" +2
			SectionSetFlags ${ar-SA} 1
		StrCmp $0 "1026" "" +2
			SectionSetFlags ${bg-BG} 1
		StrCmp $0 "1028" "" +2
			SectionSetFlags ${zh-TW} 1
		StrCmp $0 "1029" "" +2
			SectionSetFlags ${cs-CZ} 1
		StrCmp $0 "1030" "" +2
			SectionSetFlags ${da-DK} 1
		StrCmp $0 "1031" "" +2
			SectionSetFlags ${de-DE} 1
		StrCmp $0 "1032" "" +2
			SectionSetFlags ${el-GR} 1
		StrCmp $0 "1033" "" "" ; English
		StrCmp $0 "1034" "" +2
			SectionSetFlags ${es-ES} 1
		StrCmp $0 "1035" "" +2
			SectionSetFlags ${fi-FI} 1
		StrCmp $0 "1036" "" +2
			SectionSetFlags ${fr-FR} 1
		StrCmp $0 "1037" "" +2
			SectionSetFlags ${he-IL} 1
		StrCmp $0 "1038" "" +2
			SectionSetFlags ${hu-HU} 1
		StrCmp $0 "1040" "" +2
			SectionSetFlags ${it-IT} 1
		StrCmp $0 "1041" "" +2
			SectionSetFlags ${ja-JP} 1
		StrCmp $0 "1042" "" +2
			SectionSetFlags ${ko-KR} 1
		StrCmp $0 "1043" "" +2
			SectionSetFlags ${nl-NL} 1
		StrCmp $0 "1044" "" +2
			SectionSetFlags ${nb-NO} 1
		StrCmp $0 "1045" "" +2
			SectionSetFlags ${pl-PL} 1
		StrCmp $0 "1046" "" +2
			SectionSetFlags ${pt-BR} 1
		StrCmp $0 "1048" "" +2
			SectionSetFlags ${ro-RO} 1
		StrCmp $0 "1049" "" +2
			SectionSetFlags ${ru-RU} 1
		StrCmp $0 "1050" "" +2
			SectionSetFlags ${hr-HR} 1
		StrCmp $0 "1051" "" +2
			SectionSetFlags ${sk-SK} 1
		StrCmp $0 "1053" "" +2
			SectionSetFlags ${sv-SE} 1
		StrCmp $0 "1054" "" +2
			SectionSetFlags ${th-TH} 1
		StrCmp $0 "1055" "" +2
			SectionSetFlags ${tr-TR} 1
		StrCmp $0 "1058" "" +2
			SectionSetFlags ${uk-UA} 1
		StrCmp $0 "1060" "" +2
			SectionSetFlags ${sl-SI} 1
		StrCmp $0 "1061" "" +2
			SectionSetFlags ${et-EE} 1
		StrCmp $0 "1062" "" +2
			SectionSetFlags ${lv-LV} 1
		StrCmp $0 "1063" "" +2
			SectionSetFlags ${lt-LT} 1
		StrCmp $0 "1081" "" +2
			SectionSetFlags ${hi-IN} 1
		StrCmp $0 "1087" "" +2
			SectionSetFlags ${kk-KZ} 1
		StrCmp $0 "2052" "" +2
			SectionSetFlags ${zh-CN} 1
		StrCmp $0 "2070" "" +2
			SectionSetFlags ${pt-PT} 1
		StrCmp $0 "3076" "" +2
			SectionSetFlags ${zh-HK} 1
	FunctionEnd
!endif

!ifdef COMPONENTS
	Section "Templates" OfficeTemplates
		SetDetailsPrint textonly
		DetailPrint "Extracting ${APPNAME} Portable..."
		SetDetailsPrint listonly
		SetDetailsView hide

		SetOutPath "$INSTDIR\App\Templates"
			File /r /x thumbs.db /x Readme.txt "..\..\App\Templates\*.*"
	SectionEnd
!endif

!ifdef INIT
	Function Init
		; === Destroy size lol ===
		SectionSetSize ${Main} 0
		SectionSetSize ${ar-SA} 0
		SectionSetSize ${bg-BG} 0
		SectionSetSize ${zh-TW} 0
		SectionSetSize ${cs-CZ} 0
		SectionSetSize ${da-DK} 0
		SectionSetSize ${de-DE} 0
		SectionSetSize ${el-GR} 0
		SectionSetSize ${en-US} 0
		SectionSetSize ${es-ES} 0
		SectionSetSize ${fi-FI} 0
		SectionSetSize ${fr-FR} 0
		SectionSetSize ${he-IL} 0
		SectionSetSize ${hu-HU} 0
		SectionSetSize ${it-IT} 0
		SectionSetSize ${ja-JP} 0
		SectionSetSize ${ko-KR} 0
		SectionSetSize ${nl-NL} 0
		SectionSetSize ${nb-NO} 0
		SectionSetSize ${pl-PL} 0
		SectionSetSize ${pt-BR} 0
		SectionSetSize ${ro-RO} 0
		SectionSetSize ${ru-RU} 0
		SectionSetSize ${hr-HR} 0
		SectionSetSize ${sk-SK} 0
		SectionSetSize ${sv-SE} 0
		SectionSetSize ${th-TH} 0
		SectionSetSize ${tr-TR} 0
		SectionSetSize ${uk-UA} 0
		SectionSetSize ${sl-SI} 0
		SectionSetSize ${et-EE} 0
		SectionSetSize ${lv-LV} 0
		SectionSetSize ${lt-LT} 0
		SectionSetSize ${hi-IN} 0
		SectionSetSize ${kk-KZ} 0
		SectionSetSize ${zh-CN} 0
		SectionSetSize ${pt-PT} 0
		SectionSetSize ${zh-HK} 0
		SectionSetSize ${OfficeTemplates} 0
	FunctionEnd
!endif
