Extensions:
c#
nuget Package manager
vistual Studio IntelliCode
vscode-icons
dotnet Core Command line"
dotnet new sln -n "vscodeIntro"
dotnet new console -n "IntroUI"
dotnet new classlib -n "IntroLibrary"
dotnet sln vscodeIntro.sln add ./IntroUI/IntroUI.csproj
dotnet sln vscodeIntro.sln add ./vscodeIntro/IntroLibrary.csproj
dotnet add ./IntroUI/IntroUI.csproj reference ./vscodeIntro/IntroLibrary.csproj

https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-sln

First find the terminal in Visual Studio Code



Create your new repository on GitHub. Do not adde README, license or gitignore for now. Note the “remote repository URL”, which you will need in step 7 instead of **URL**.
Open terminal
Initialize a new Git repository: git init
Stage your files before first commit: git add.
Commit the files: git commit -m “Project started”
Add remote repository: git remote add origin **URL**
Verify the remote repository: git remote -v
Push the first changes: git push -u origin master