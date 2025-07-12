#!/bin/sh

FrameworkPathOverride=$(dirname $(which mono))/../lib/mono/4.7.2-api/ dotnet build *.csproj /property:Configuration=Debug

rm -rf ../1.6/Assemblies/
mkdir ../1.6/Assemblies/

ln -s $(realpath bin/Debug)/Zig158.BetterBodyPurist.dll $(realpath ../1.6/Assemblies/)/Zig158.BetterBodyPurist.dll
ln -s $(realpath bin/Debug)/Zig158.BetterBodyPurist.pdb $(realpath ../1.6/Assemblies/)/Zig158.BetterBodyPurist.pdb

rm -rf $RIMWORLD_MOD_DIR/BetterBodyPurist
mkdir $RIMWORLD_MOD_DIR/BetterBodyPurist
ln -s $(realpath ../)/LICENSE $(realpath $RIMWORLD_MOD_DIR/BetterBodyPurist)/LICENSE
ln -s $(realpath ../)/About $(realpath $RIMWORLD_MOD_DIR/BetterBodyPurist)/About
ln -s $(realpath ../)/1.5 $(realpath $RIMWORLD_MOD_DIR/BetterBodyPurist)/1.5
ln -s $(realpath ../)/1.6 $(realpath $RIMWORLD_MOD_DIR/BetterBodyPurist)/1.6