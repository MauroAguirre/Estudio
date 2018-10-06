; Last built: 2013-12-10

; === Registry ===
!define registry::BackupLocal "!insertmacro registry::BackupLocal"
!macro registry::BackupLocal _REGKEY
	registry::_DeleteKey /NOUNLOAD "${_REGKEY}-BackupBy${APP}Portable"
	registry::_MoveKey /NOUNLOAD "${_REGKEY}" "${_REGKEY}-BackupBy${APP}Portable"
!macroend

!define registry::RestoreLocal "!insertmacro registry::RestoreLocal"
!macro registry::RestoreLocal _REGKEY
	registry::_DeleteKey /NOUNLOAD "${_REGKEY}"
	registry::_MoveKey /NOUNLOAD "${_REGKEY}-BackupBy${APP}Portable" "${_REGKEY}"
!macroend

!define registry::RestorePortable "!insertmacro registry::RestorePortable"
!macro registry::RestorePortable
	registry::_RestoreKey /NOUNLOAD "$EXEDIR\Data\${APP}.reg"
	Sleep 200
!macroend

!define registry::BackupPortable "!insertmacro registry::BackupPortable"
!macro registry::BackupPortable _REGKEY
	registry::_SaveKey /NOUNLOAD "${_REGKEY}" "$EXEDIR\Data\${APP}.reg" "/U=1 /A=1"
	Sleep 100
!macroend

!define registry::BackupValue "!insertmacro registry::BackupValue"
!macro registry::BackupValue _REGKEYVALUE _REGVALUE
	registry::_DeleteValue /NOUNLOAD "${_REGKEYVALUE}" "${_REGVALUE}-BackupBy${APP}Portable"
	registry::_MoveValue /NOUNLOAD "${_REGKEYVALUE}" "${_REGVALUE}" "${_REGKEYVALUE}" "${_REGVALUE}-BackupBy${APP}Portable"
!macroend

!define registry::RestoreValue "!insertmacro registry::RestoreValue"
!macro registry::RestoreValue _REGKEYVALUE _REGVALUE
	registry::_DeleteValue /NOUNLOAD "${_REGKEYVALUE}" "${_REGVALUE}"
	registry::_MoveValue /NOUNLOAD "${_REGKEYVALUE}" "${_REGVALUE}-BackupBy${APP}Portable" "${_REGKEYVALUE}" "${_REGVALUE}"
!macroend

!define registry::BackupShell "!insertmacro registry::BackupShell"
!macro registry::BackupShell _REGKEYSHELL _REGSHELL
	registry::_DeleteKey /NOUNLOAD "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\${_REGKEYSHELL}\${_REGSHELL}-BackupBy${APP}Portable"
	registry::_MoveKey /NOUNLOAD "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\${_REGKEYSHELL}\shell\${_REGSHELL}" "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\${_REGKEYSHELL}\${_REGSHELL}-BackupBy${APP}Portable"
!macroend

!define registry::RestoreShell "!insertmacro registry::RestoreShell"
!macro registry::RestoreShell _REGKEYSHELL _REGSHELL
	registry::_DeleteKey /NOUNLOAD "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\${_REGKEYSHELL}\shell\${_REGSHELL}"
	registry::_MoveKey /NOUNLOAD "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\${_REGKEYSHELL}\${_REGSHELL}-BackupBy${APP}Portable" "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\${_REGKEYSHELL}\shell\${_REGSHELL}"
!macroend

!define registry::BackupShellEx "!insertmacro registry::BackupShellEx"
!macro registry::BackupShellEx _REGKEYSHELLEX _TYPESHELLEX _REGSHELLEX
	registry::_DeleteKey /NOUNLOAD "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\${_REGKEYSHELLEX}\${_TYPESHELLEX}${_REGSHELLEX}-BackupBy${APP}Portable"
	registry::_MoveKey /NOUNLOAD "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\${_REGKEYSHELLEX}\shellex\${_TYPESHELLEX}\${_REGSHELLEX}" "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\${_REGKEYSHELLEX}\${_TYPESHELLEX}${_REGSHELLEX}-BackupBy${APP}Portable"
!macroend

!define registry::RestoreShellEx "!insertmacro registry::RestoreShellEx"
!macro registry::RestoreShellEx _REGKEYSHELLEX _TYPESHELLEX _REGSHELLEX
	registry::_DeleteKey /NOUNLOAD "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\${_REGKEYSHELLEX}\shellex\${_TYPESHELLEX}\${_REGSHELLEX}"
	registry::_MoveKey /NOUNLOAD "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\${_REGKEYSHELLEX}\${_TYPESHELLEX}${_REGSHELLEX}-BackupBy${APP}Portable" "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\${_REGKEYSHELLEX}\shellex\${_TYPESHELLEX}\${_REGSHELLEX}"
!macroend

; === Directories ===
!define directory::BackupLocal "!insertmacro directory::BackupLocal"
!macro directory::BackupLocal _LOCALDIR _SUBDIR
	RMDir "/r" "${_LOCALDIR}${_SUBDIR}-BackupBy${APP}Portable"
	Rename "${_LOCALDIR}${_SUBDIR}" "${_LOCALDIR}${_SUBDIR}-BackupBy${APP}Portable"
!macroend

!define directory::RestoreLocal "!insertmacro directory::RestoreLocal"
!macro directory::RestoreLocal _LOCALDIR _SUBDIR
	RMDir "/r" "${_LOCALDIR}${_SUBDIR}"
	Rename "${_LOCALDIR}${_SUBDIR}-BackupBy${APP}Portable" "${_LOCALDIR}${_SUBDIR}"
	RMDir "${_LOCALDIR}${_SUBDIR}"
!macroend

!define directory::BackupLocalAll "!insertmacro directory::BackupLocalAll"
!macro directory::BackupLocalAll _LOCALDIR _SUBDIR
	SetShellVarContext all
		RMDir "/r" "${_LOCALDIR}${_SUBDIR}-BackupBy${APP}Portable"
		Rename "${_LOCALDIR}${_SUBDIR}" "${_LOCALDIR}${_SUBDIR}-BackupBy${APP}Portable"
	SetShellVarContext current
!macroend

!define directory::RestoreLocalAll "!insertmacro directory::RestoreLocalAll"
!macro directory::RestoreLocalAll _LOCALDIR _SUBDIR
	SetShellVarContext all
		RMDir "/r" "${_LOCALDIR}${_SUBDIR}"
		Rename "${_LOCALDIR}${_SUBDIR}-BackupBy${APP}Portable" "${_LOCALDIR}${_SUBDIR}"
		RMDir "${_LOCALDIR}${_SUBDIR}"
	SetShellVarContext current
!macroend

!define directory::DefaultPortable "!insertmacro directory::DefaultPortable"
!macro directory::DefaultPortable _PORTABLEDIR _DEFAULTPORTABLEDIR
	IfFileExists "${_DEFAULTPORTABLEDIR}\*.*" "" +4
		IfFileExists "${_PORTABLEDIR}\*.*" +3
			CreateDirectory "${_PORTABLEDIR}"
				CopyFiles /SILENT  "${_DEFAULTPORTABLEDIR}\*.*" "${_PORTABLEDIR}"
!macroend

!define directory::RestorePortable "!insertmacro directory::RestorePortable"
!macro directory::RestorePortable _LOCALDIR _SUBDIR _PORTABLEDIR
	CreateDirectory "${_LOCALDIR}${_SUBDIR}"
		CopyFiles /SILENT "${_PORTABLEDIR}\*.*" "${_LOCALDIR}${_SUBDIR}"
!macroend

!define directory::BackupPortable "!insertmacro directory::BackupPortable"
!macro directory::BackupPortable _PORTABLEDIR _LOCALDIR _SUBDIR
	RMDir "/r" "${_PORTABLEDIR}"
	CreateDirectory "${_PORTABLEDIR}"
		CopyFiles /SILENT "${_LOCALDIR}${_SUBDIR}\*.*" "${_PORTABLEDIR}"
!macroend

!define directory::RestorePortableAll "!insertmacro directory::RestorePortableAll"
!macro directory::RestorePortableAll _LOCALDIR _SUBDIR _PORTABLEDIR
	SetShellVarContext all
		CreateDirectory "${_LOCALDIR}${_SUBDIR}"
			CopyFiles /SILENT "${_PORTABLEDIR}\*.*" "${_LOCALDIR}${_SUBDIR}"
	SetShellVarContext current
!macroend

!define directory::BackupPortableAll "!insertmacro directory::BackupPortableAll"
!macro directory::BackupPortableAll _PORTABLEDIR _LOCALDIR _SUBDIR
	SetShellVarContext all
		RMDir "/r" "${_PORTABLEDIR}"
		CreateDirectory "${_PORTABLEDIR}"
			CopyFiles /SILENT "${_LOCALDIR}${_SUBDIR}\*.*" "${_PORTABLEDIR}"
	SetShellVarContext current
!macroend

; === Files ===
!define file::BackupLocal "!insertmacro file::BackupLocal"
!macro file::BackupLocal _LOCALFILE
	Delete "${_LOCALFILE}.BackupBy${APP}Portable"
	Rename "${_LOCALFILE}" "${_LOCALFILE}.BackupBy${APP}Portable"
!macroend

!define file::RestoreLocal "!insertmacro file::RestoreLocal"
!macro file::RestoreLocal _LOCALFILE
	Delete "${_LOCALFILE}"
	Rename "${_LOCALFILE}.BackupBy${APP}Portable" "${_LOCALFILE}"
!macroend

!define file::BackupLocalAll "!insertmacro file::BackupLocalAll"
!macro file::BackupLocalAll _LOCALFILE
	SetShellVarContext all
		Delete "${_LOCALFILE}.BackupBy${APP}Portable"
		Rename "${_LOCALFILE}" "${_LOCALFILE}.BackupBy${APP}Portable"
	SetShellVarContext current
!macroend

!define file::RestoreLocalAll "!insertmacro file::RestoreLocalAll"
!macro file::RestoreLocalAll _LOCALFILE
	SetShellVarContext all
		Delete "${_LOCALFILE}"
		Rename "${_LOCALFILE}.BackupBy${APP}Portable" "${_LOCALFILE}"
	SetShellVarContext current
!macroend

!define file::DefaultPortable "!insertmacro file::DefaultPortable"
!macro file::DefaultPortable _PORTABLEFILE _DEFAULTPORTABLEFILE
	IfFileExists "${_DEFAULTPORTABLEFILE}" "" +4
		IfFileExists "${_PORTABLEFILE}" +3
			CreateDirectory "$EXEDIR\Data"
				CopyFiles /SILENT "${_DEFAULTPORTABLEFILE}" "$EXEDIR\Data"
!macroend

!define file::RestorePortable "!insertmacro file::RestorePortable"
!macro file::RestorePortable _PORTABLEFILE _LOCALFILE
	Rename  "${_PORTABLEFILE}" "${_LOCALFILE}"
!macroend

!define file::BackupPortable "!insertmacro file::BackupPortable"
!macro file::BackupPortable _PORTABLEFILE _LOCALFILE
	CreateDirectory "$EXEDIR\Data"
		Delete "${_PORTABLEFILE}"
		Rename "${_LOCALFILE}" "${_PORTABLEFILE}"
!macroend

!define file::RestorePortableAll "!insertmacro file::RestorePortableAll"
!macro file::RestorePortableAll _PORTABLEFILE _LOCALFILE
	SetShellVarContext all
		Rename  "${_PORTABLEFILE}" "${_LOCALFILE}"
	SetShellVarContext current
!macroend

!define file::BackupPortableAll "!insertmacro file::BackupPortableAll"
!macro file::BackupPortableAll _PORTABLEFILE _LOCALFILE
	SetShellVarContext all
		CreateDirectory "$EXEDIR\Data"
			Delete "${_PORTABLEFILE}"
			Rename "${_LOCALFILE}" "${_PORTABLEFILE}"
	SetShellVarContext current
!macroend

; === DLLs ===
!define dll::UnRegLocal "!insertmacro dll::UnRegLocal"
!macro dll::UnRegLocal _CLSID _DLLID
	registry::_KeyExists /NOUNLOAD "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\${_CLSID}"
	Pop $0
	StrCmp $0 "-1" +8 ; skip next 7 line if key doesn't exist
		ReadRegStr $0 HKEY_LOCAL_MACHINE "SOFTWARE\Classes\CLSID\${_CLSID}\InprocServer32" ""
			IfFileExists "$0" "" +6 ; skip next 5 line if file doesn't exist
				CreateDirectory "$EXEDIR\Data"
					ReadINIStr $1 "$EXEDIR\Data\${APP}PortableRuntimeData.ini" "${APP}Portable" "${_DLLID}"
					StrCmp $1 "" "" +3 ; skip next 2 line if have been written
						WriteINIStr "$EXEDIR\Data\${APP}PortableRuntimeData.ini" "${APP}Portable" "${_DLLID}" "$0"
						UnRegDLL "$0"
!macroend

!define dll::RegLocal "!insertmacro dll::RegLocal"
!macro dll::RegLocal _DLLID
	ReadINIStr $0 "$EXEDIR\Data\${APP}PortableRuntimeData.ini" "${APP}Portable" "${_DLLID}"
	StrCmp $0 "" +3
		IfFileExists "$0" "" +2
			RegDLL "$0"
!macroend

!define dll::UnRegLocal64 "!insertmacro dll::UnRegLocal64"
!macro dll::UnRegLocal64 _CLSID64 _DLLID64
	SetRegView 64
		registry::_KeyExists /NOUNLOAD "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\${_CLSID64}"
		Pop $0
		StrCmp $0 "-1" +8 ; skip next 7 line if key doesn't exist
			ReadRegStr $0 HKEY_LOCAL_MACHINE "SOFTWARE\Classes\CLSID\${_CLSID64}\InprocServer32" ""
				IfFileExists "$0" "" +6 ; skip next 5 line if file doesn't exist
					CreateDirectory "$EXEDIR\Data"
						ReadINIStr $1 "$EXEDIR\Data\${APP}PortableRuntimeData.ini" "${APP}Portable" "${_DLLID64}"
						StrCmp $1 "" "" +3 ; skip next 2 line if have been written
							WriteINIStr "$EXEDIR\Data\${APP}PortableRuntimeData.ini" "${APP}Portable" "${_DLLID64}" "$0"
							ExecWait `"$SYSDIR\regsvr32.exe" /u /s "$0"`
	SetRegView 32
!macroend

!define dll::RegLocal64 "!insertmacro dll::RegLocal64"
!macro dll::RegLocal64 _DLLID64
	ReadINIStr $0 "$EXEDIR\Data\${APP}PortableRuntimeData.ini" "${APP}Portable" "${_DLLID64}"
	StrCmp $0 "" +3
		IfFileExists "$0" "" +2
			ExecWait `"$SYSDIR\regsvr32.exe" /s "$0"`
!macroend

; === TLBs ===
!define TypeLib::UnRegLocal "!insertmacro TypeLib::UnRegLocal"
!macro TypeLib::UnRegLocal _TYPELIB _TLBVER
	registry::_KeyExists /NOUNLOAD "HKEY_LOCAL_MACHINE\SOFTWARE\Classes\TypeLib\${_TYPELIB}"
	Pop $0
	StrCmp $0 "-1" +6 ; if key doesn't exist
		ReadRegStr $0 HKEY_LOCAL_MACHINE "SOFTWARE\Classes\TypeLib\${_TYPELIB}\${_TLBVER}\win32" ""
			IfFileExists "$0" "" +4
				CreateDirectory "$EXEDIR\Data"
					WriteINIStr "$EXEDIR\Data\${APP}PortableRuntimeData.ini" "${APP}Portable" "${_TYPELIB}" "$0"
				TypeLib::Unregister "$0"
!macroend

!define TypeLib::RegLocal "!insertmacro TypeLib::RegLocal"
!macro TypeLib::RegLocal _TYPELIB
	ReadINIStr $0 "$EXEDIR\Data\${APP}PortableRuntimeData.ini" "${APP}Portable" "${_TYPELIB}"
	StrCmp $0 "" +3
		IfFileExists "$0" "" +2
			TypeLib::Register "$0"
!macroend

; === Services ===
!define src::DelLocal "!insertmacro src::DelLocal"
!macro src::DelLocal _SRC
	registry::_KeyExists /NOUNLOAD "HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\services\${_SRC}"
	Pop $0
	StrCmp $0 "-1" +16
		ReadRegStr $0 HKEY_LOCAL_MACHINE "SYSTEM\CurrentControlSet\services\${_SRC}" "ImagePath"
		StrCpy $1 "$0" 4
		StrCmp $1 "\??\" "" +2
			StrCpy $0 "$0" "" 4 ; fix path: \??\C:\Program Files\MyProg\MyProgService.exe => C:\Program Files\MyProg\MyProgService.exe
		StrCpy $1 "$0" 1
		StrCmp $1 `"` "" +2
			StrCpy $0 "$0" "" 1 ; remove begin quote
		StrCpy $1 "$0" "" -1
		StrCmp $1 `"` "" +2
			StrCpy $0 "$0" -1 ; remove end quote
		IfFileExists "$0" "" +5
			CreateDirectory "$EXEDIR\Data"
				WriteINIStr "$EXEDIR\Data\${APP}PortableRuntimeData.ini" "${APP}Portable" "${_SRC}" "$0"
			nsSCM::Stop "${_SRC}"
			nsSCM::Remove "${_SRC}"
!macroend

!define src::CreateLocal "!insertmacro src::CreateLocal"
!macro src::CreateLocal _SRC _SRCNAME _TYPESRC _STARTSRC
	ReadINIStr $0 "$EXEDIR\Data\${APP}PortableRuntimeData.ini" "${APP}Portable" "${_SRC}"
	StrCmp $0 "" +3
		IfFileExists "$0" "" +2
			nsSCM::Install "${_SRC}" "${_SRCNAME}" "${_TYPESRC}" "${_STARTSRC}" "$0" "" "" "" ""
!macroend

!define src::CreatePortable "!insertmacro src::CreatePortable"
!macro src::CreatePortable _SRC _SRCNAME _TYPESRC _STARTSRC _PORTABLESRC
	nsSCM::Install "${_SRC}" "${_SRCNAME}" "${_TYPESRC}" "${_STARTSRC}" "${_PORTABLESRC}" "" "" "" ""
	nsSCM::Start "${_SRC}"
!macroend

!define src::DelPortable "!insertmacro src::DelPortable"
!macro src::DelPortable _SRC
	nsSCM::Stop "${_SRC}"
	nsSCM::Remove "${_SRC}"
!macroend

; === VC ===
!define vc::CopyLocal "!insertmacro vc::CopyLocal"
!macro vc::CopyLocal _VC
	IfFileExists "$WINDIR\WinSxS\${_VC}\*.*" +7
		CreateDirectory "$EXEDIR\Data"
			WriteINIStr "$EXEDIR\Data\${APP}PortableRuntimeData.ini" "${APP}Portable" "${_VC}" "false"
		CreateDirectory "$WINDIR\WinSxS\${_VC}"
			CopyFiles /SILENT "$EXEDIR\App\WinSxS\${_VC}\*.*" "$WINDIR\WinSxS\${_VC}"
			CopyFiles /SILENT "$EXEDIR\App\WinSxS\Manifests\${_VC}.manifest" "$WINDIR\WinSxS\Manifests"
			CopyFiles /SILENT "$EXEDIR\App\WinSxS\Manifests\${_VC}.cat" "$WINDIR\WinSxS\Manifests"
!macroend

!define vc::DelLocal "!insertmacro vc::DelLocal"
!macro vc::DelLocal _VC
	ReadINIStr $0 "$EXEDIR\Data\${APP}PortableRuntimeData.ini" "${APP}Portable" "${_VC}"
	StrCmp $0 "false" "" +4
		RMDir "/r" "$WINDIR\WinSxS\${_VC}"
		Delete "$WINDIR\WinSxS\Manifests\${_VC}.manifest"
		Delete "$WINDIR\WinSxS\Manifests\${_VC}.cat"
!macroend

!define vc::CopyLocalPolicies "!insertmacro vc::CopyLocalPolicies"
!macro vc::CopyLocalPolicies _VCP
	IfFileExists "$WINDIR\WinSxS\Policies\${_VCP}\*.*" +5
		CreateDirectory "$EXEDIR\Data"
			WriteINIStr "$EXEDIR\Data\${APP}PortableRuntimeData.ini" "${APP}Portable" "${_VCP}" "false"
		CreateDirectory "$WINDIR\WinSxS\Policies\${_VCP}"
			CopyFiles /SILENT "$EXEDIR\App\WinSxS\Policies\${_VCP}\*.*" "$WINDIR\WinSxS\Policies\${_VCP}"
!macroend

!define vc::DelLocalPolicies "!insertmacro vc::DelLocalPolicies"
!macro vc::DelLocalPolicies _VCP
	ReadINIStr $0 "$EXEDIR\Data\${APP}PortableRuntimeData.ini" "${APP}Portable" "${_VCP}"
	StrCmp $0 "false" "" +2
		RMDir "/r" "$WINDIR\WinSxS\Policies\${_VCP}"
!macroend
