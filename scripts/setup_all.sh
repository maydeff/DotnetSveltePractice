#!/bin/bash

echo "SETUP ALL STARTED..."
path="$(pwd)/config.json"
echo "PATH: $path"

# Enclose the $path variable in double quotes when passing it as an argument
./mongo/setup_mongo.sh "$path" &&
./postgre/setup_postgre.sh "$path"
