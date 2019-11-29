#!/bin/bash
cd JenkinsPipelineApp
dotnet build --configuration Release -o ../dist
cd ..
