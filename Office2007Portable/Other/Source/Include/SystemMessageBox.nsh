; Azure Zanculmarktum

; Usage:
;        !include SystemMessageBox.nsh
;        ${System::MessageBox} "[MB_OPTIONLIST]" "[Caption]" "[Message]" $return_value
;        ${System::CustomMessageBox} "[MB_OPTON_LIST]" "[File]" "[Icon_ID]" "[Caption]" "[Message]" $return_value
;
; Example:
;        ${System::MessageBox} "${MB_ICONINFORMATION}" "Example" "Message box with caption `Example`!" $0
;        ${System::CustomMessageBox} "${MB_OK}" "$WINDIR\notepad.exe" "2" "Example" "Message box with custom icon from notepad.exe!" $0
;
; Return value:
;        OK        = 1
;        Cancel    = 2
;        Abort     = 3
;        Retry     = 4
;        Ignore    = 5
;        Yes       = 6
;        No        = 7

!define MB_OK                       0x00000000
!define MB_OKCANCEL                 0x00000001
!define MB_ABORTRETRYIGNORE         0x00000002
!define MB_RETRYCANCEL              0x00000005
!define MB_YESNO                    0x00000004
!define MB_YESNOCANCEL              0x00000003

!define MB_ICONEXCLAMATION          0x00000030
!define MB_ICONINFORMATION          0x00000040
!define MB_ICONQUESTION             0x00000020
!define MB_ICONSTOP                 0x00000010
!define MB_USERICON                 0x00000080

!define MB_TOPMOST                  0x00040000
!define MB_SETFOREGROUND            0x00010000
!define MB_RIGHT                    0x00080000
!define MB_RTLREADING               0x00100000

!define MB_DEFBUTTON1               0x00000000
!define MB_DEFBUTTON2               0x00000100
!define MB_DEFBUTTON3               0x00000200
!define MB_DEFBUTTON4               0x00000300

!define System::MessageBox "!insertmacro System::MessageBox"
!macro System::MessageBox _MBOPTIONLIST _CAPTION _MESSAGE _RETURNVALUE
	!ifdef NSIS_UNICODE
		System::Call `kernel32::GetModuleHandleW(t) i(i 0) .r1`
	!else
		System::Call `kernel32::GetModuleHandleA(t) i(i 0) .r1`
	!endif
	System::Call `*(&l4, i, i, t, t, i, t, i, k, i) i(, $HWNDPARENT, r1, "${_MESSAGE}", "${_CAPTION}", "${_MBOPTIONLIST}|0x00009000", i 103, _) .r0`
	!ifdef NSIS_UNICODE
		System::Call `user32::MessageBoxIndirectW(i) i(r0) .R0, .r1`
	!else
		System::Call `user32::MessageBoxIndirectA(i) i(r0) .R0, .r1`
	!endif
	StrCpy ${_RETURNVALUE} "$1"
!macroend

; === MessageBox with custom icon ===
!define System::CustomMessageBox "!insertmacro System::CustomMessageBox"
!macro System::CustomMessageBox _MBOPTIONLIST _FILE _ICONID _CAPTION _MESSAGE _RETURNVALUE
	!ifdef NSIS_UNICODE
		System::Call `kernel32::LoadLibraryW(t) i("${_FILE}") .r1`
	!else
		System::Call `kernel32::LoadLibraryA(t) i("${_FILE}") .r1`
	!endif
	System::Call `*(&l4, i, i, t, t, i, t, i, k, i) i(, $HWNDPARENT, r1, "${_MESSAGE}", "${_CAPTION}", "${_MBOPTIONLIST}|${MB_USERICON}|0x00009000", i ${_ICONID}, _) .r0`
	!ifdef NSIS_UNICODE
		System::Call `user32::MessageBoxIndirectW(i) i(r0) .R0, .r1`
	!else
		System::Call `user32::MessageBoxIndirectA(i) i(r0) .R0, .r1`
	!endif
	StrCpy ${_RETURNVALUE} "$1"
!macroend
