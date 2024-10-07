#!/bin/sh

FrameworkPathOverride=$(dirname $(which mono))/../lib/mono/4.7.2-api/ dotnet build *.csproj /property:Configuration=Debug

rm -rf ../1.5/
mkdir ../1.5
mkdir ../1.5/Assemblies/

ln -s $(realpath bin/Debug)/Zig158.BetterBodyPurest.dll $(realpath ../1.5/Assemblies/)/Zig158.BetterBodyPurest.dll
ln -s $(realpath bin/Debug)/Zig158.BetterBodyPurest.pdb $(realpath ../1.5/Assemblies/)/Zig158.BetterBodyPurest.pdb
ln -s $(realpath Patches) $(realpath ../1.5/Patches)