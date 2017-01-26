cd ..\source
"C:\Program Files (x86)\Microsoft Visual Studio 14.0\Common7\IDE\devenv.exe" Jobbr.ComponentModel.ArtefactStorage.sln /Build "Release|Any CPU"
cp Jobbr.ComponentModel.ArtefactStorage/bin/Release/Jobbr.ComponentModel.ArtefactStorage.* ..\tools\
cd ..\tools
