#!/bin/bash

# Define an array of container names to stop
containers_to_stop=("my-mongodb-demo")

# Define ANSI color codes for colored output
RED='\033[0;31m'
GREEN='\033[0;32m'
NC='\033[0m' # No Color

# Loop through the list of container names and stop them
for container_name in "${containers_to_stop[@]}"; do
    # Check if the container exists
    if docker ps -a --format '{{.Names}}' | grep -q "^$container_name$"; then
        # Stop the container
        docker stop $container_name

        # Print a colored success message
        echo -e "${GREEN}Container $container_name has been stopped.${NC}"
    else
        # Print a colored error message
        echo -e "${RED}Container $container_name not found.${NC}"
    fi
done
