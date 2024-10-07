#!/bin/sh

FrameworkPathOverride=$(dirname $(which mono))/../lib/mono/4.7.2-api/ dotnet build *.csproj /property:Configuration=Release

rm -rf ../1.5/
mkdir ../1.5
mkdir ../1.5/Assemblies/
mkdir ../1.5/Patches/

cp bin/Release/Zig158.BetterBodyPurest.dll ../1.5/Assemblies/
cp Patches/* ../1.5/Patches/