#!/bin/sh

FrameworkPathOverride=$(dirname $(which mono))/../lib/mono/4.7.2-api/ dotnet build *.csproj /property:Configuration=Debug

rm -rf ../1.5/Assemblies/
mkdir ../1.5/Assemblies/


ln -s $(realpath bin/Debug)/Zig158.BetterBodyPurist.dll $(realpath ../1.5/Assemblies/)/Zig158.BetterBodyPurist.dll
ln -s $(realpath bin/Debug)/Zig158.BetterBodyPurist.pdb $(realpath ../1.5/Assemblies/)/Zig158.BetterBodyPurist.pdb
