set PATH=%PATH%;C:\Program Files\IIS Express\"
msbuild .\tools\site.build
iisexpress /path:%CD%\public