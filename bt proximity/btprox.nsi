!include LogicLib.nsh
Name BtProx
InstallDir $PROGRAMFILES\BtProx
InstallDirRegKey HKLM "Software\BtProx" "InstallDirectory"
Icon "orange_large.ico"
UninstallIcon "orange_large.ico"
XPStyle on
OutFile "btprox.exe"

; Uninstall script copied from
; http://nsis.sourceforge.net/Uninstall_only_installed_files
!include "create_list.nsi"

Page directory
Page instfiles

UninstPage uninstConfirm
UninstPage instfiles

; Mandatory base files
Section "Base Files" sec_BaseFiles
    SectionIn RO
    ${SetOutPath} $INSTDIR
    ${File} "bin\Release\" "btprox.exe"
    ${File} ".\" "InTheHand.Net.Personal.dll"
    ${File} ".\" "InTheHandLicense.txt"
    ${File} "bin\Release\" "btprox.exe.config"

    ${SetOutPath} $INSTDIR\es
    ${File} "bin\Release\es\" "btprox.resources.dll"

    ${SetOutPath} $INSTDIR\ru
    ${File} "bin\Release\ru\" "btprox.resources.dll"

    ${SetOutPath} $INSTDIR\he
    ${File} "bin\Release\he\" "btprox.resources.dll"

    ${SetOutPath} $INSTDIR\de
    ${File} "bin\Release\de\" "btprox.resources.dll"
SectionEnd

; writing uninstaller
Section "-Uninstaller" sec_Uninstaller
    SectionIn RO
    ${SetOutPath} $INSTDIR
    ${WriteUninstaller} "uninstall.exe"
SectionEnd

Section "-Registry" sec_Registry
    SectionIn RO

    WriteRegStr HKLM "Software\BtProx" "InstallDirectory" "$INSTDIR"

    ; Write the uninstall keys for Windows
    WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\BtProx" "DisplayName" "BtProx"
    WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\BtProx" "UninstallString" '"$INSTDIR\uninstall.exe"'
    WriteRegDWORD HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\BtProx" "NoModify" 1
    WriteRegDWORD HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\BtProx" "NoRepair" 1
    WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\BtProx" "URLInfoAbout" "http://support.microsoft.com/kb/936982"
    WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\BtProx" "Comments" "Bluetooth proximity detector"
    WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\BtProx" "Publisher" "Uri Kogan"
SectionEnd

Section "Start Menu Shortcuts" sec_StartMenu
    SetShellVarContext "all"
    CreateDirectory "$SMPROGRAMS\BtProx"
    CreateShortCut "$SMPROGRAMS\BtProx\Uninstall.lnk" \
        "$INSTDIR\uninstall.exe" "" "$INSTDIR'uninstall.exe" 0
    CreateShortCut "$SMPROGRAMS\BtProx\BtProx.lnk" \
        "$INSTDIR\BtProx.exe" "" "$INSTDIR\BtProx.exe" 0
    CreateShortCut "$SMSTARTUP\BtProx.lnk" \
        "$INSTDIR\BtProx.exe" "/q" "$INSTDIR\BtProx.exe" 0
SectionEnd

Section "Desktop Shortcut" sec_Desktop
    SetShellVarContext "all"
    CreateShortCut "$DESKTOP\BtProx.lnk" \
        "$INSTDIR\BtProx.exe" "" "$INSTDIR\BtProx.exe" 0
SectionEnd

Section "Uninstall"
    ; Remove registry keys
    DeleteRegKey HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\BtProx"
    DeleteRegKey HKLM SOFTWARE\BtProx

    ; Remove shortcuts from start menu
    SetShellVarContext "all"
    Delete "$SMPROGRAMS\BtProx\*.*"
    RMDir "$SMPROGRAMS\BtProx"
    Delete "$SMSTARTUP\BtProx.lnk"

    ; Remove shortcut from the desktop
    SetShellVarContext "all"
    Delete "$DESKTOP\BtProx.lnk"

    ; Can't uninstall if uninstall log is missing!
    IfFileExists "$INSTDIR\${UninstLog}" +3
        MessageBox MB_OK|MB_ICONSTOP "$(UninstLogMissing)"
            Abort

    Push $R0
    Push $R1
    Push $R2
    SetFileAttributes "$INSTDIR\${UninstLog}" NORMAL
    FileOpen $UninstLog "$INSTDIR\${UninstLog}" r
    StrCpy $R1 0

GetLineCount:
    ClearErrors
    FileRead $UninstLog $R0
    IntOp $R1 $R1 + 1
    IfErrors 0 GetLineCount

LoopRead:
    FileSeek $UninstLog 0 SET
    StrCpy $R2 0
FindLine:
    FileRead $UninstLog $R0
    IntOp $R2 $R2 + 1
    StrCmp $R1 $R2 0 FindLine

    StrCpy $R0 $R0 -2
    IfFileExists "$R0\*.*" 0 +3
        RMDir $R0  #is dir
    Goto +3
    IfFileExists $R0 0 +2
        Delete $R0 #is file

    IntOp $R1 $R1 - 1
    StrCmp $R1 0 LoopDone
    Goto LoopRead
LoopDone:
    FileClose $UninstLog
    Delete "$INSTDIR\${UninstLog}"
    RMDir "$INSTDIR"
    Pop $R2
    Pop $R1
    Pop $R0
SectionEnd

Function .onInit
   Call GetDotNETVersion
      Pop $0
   ${If} $0 == "not found"
      MessageBox MB_OK|MB_ICONINFORMATION \
          ".NET runtime library is not installed. Please, install .NET 3.5 from \
          http://www.microsoft.com/downloads/details.aspx?FamilyId=333325FD-AE52-4E35-B531-508D977D32A6" \
          /SD IDOK
      Abort
   ${EndIf}
   ${If} $1 == 2
      MessageBox MB_OK|MB_ICONSTOP \
        ".NET runtime library is not installed. Please, install .NET 3.5 from \
        http://www.microsoft.com/downloads/details.aspx?FamilyId=333325FD-AE52-4E35-B531-508D977D32A6" \
        /SD IDOK
      Abort
      Return
   ${EndIf}

FunctionEnd

Function GetDotNETVersion
   Push $0
   Push $1
 
   System::Call "mscoree::GetCORVersion(w .r0, i ${NSIS_MAX_STRLEN}, *i) i .r1"
   StrCmp $1 "error" 0 +2
   StrCpy $0 "not found"

   Pop $1
   Exch $0
FunctionEnd

; uinstall script
Section -closelogfile
 FileClose $UninstLog
 SetFileAttributes "$INSTDIR\${UninstLog}" READONLY|SYSTEM|HIDDEN
SectionEnd
