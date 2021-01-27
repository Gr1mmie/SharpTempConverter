# SharpTempConverter
Converts temperature between various units 

![image](https://user-images.githubusercontent.com/57014148/105939561-519d3d00-600e-11eb-8c7a-9f0125209a3c.png)


## Installing and compiling

The latest version of dotnet(5.0) is required to run 
* Windows Installation:

dotnet5.0 can be installed from https://dotnet.microsoft.com/download, may require a restart. Once verifying dotnet is installed (run `dotnet`), move to the directory where the repo was cloned to and run `dotnet run`.

* Linux (tested on debian/ubuntu distros) Installation:

Within the repo, I've included a script that automagically installs the latest dotnet(5.0) and adds it to your path. run `dotnet_setup.sh` and that should set everything up. If your shell is not zsh, swap out the shebang for `#!/bin/bash`.

## Running program
After dotnet installed, simply run `dotnet run` in the repo directory
