#!/bin/sh

FrameworkPathOverride=$(dirname $(which mono))/../lib/mono/4.7.2-api/ dotnet build *.csproj /property:Configuration=Release

rm -rf ../1.5/Assemblies/
mkdir ../1.5/Assemblies/

cp bin/Release/Zig158.BetterBodyPurist.dll ../1.5/Assemblies/
