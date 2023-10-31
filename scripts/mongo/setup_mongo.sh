#!/bin/bash

if [ -n "$1" ]; then
    config_file="$1"

    echo "Using config file: $config_file"
else
    default_config_file="../config.json"
    config_file=$default_config_file

    echo "Config file not provided. Using default one: $config_file"
fi

if [ ! -f "$config_file" ]; then
  echo "Config file not found: $config_file"
  exit 1
fi

MONGO_IMAGE=$(jq -r '.nosql.docker_image' "$config_file")
MONGO_CONTAINER_NAME=$(jq -r '.nosql.container_name' "$config_file")
MONGO_PORT=$(jq -r '.nosql.port' "$config_file")

# ANSI color codes for colored output
GREEN='\033[0;32m'  # Green
RED='\033[0;31m'    # Red
ORANGE='\033[0;33m' # Orange
NC='\033[0m'        # No Color

run_fresh_container () {
   # Run the MongoDB container
  echo -e "${GREEN}Starting: $MONGO_CONTAINER_NAME${NC}"
  docker run -d -p $MONGO_PORT:27017 --name $MONGO_CONTAINER_NAME $MONGO_IMAGE

  # Check if the container is running
  echo -e "${GREEN}Started: $MONGO_CONTAINER_NAME${NC}"

  if [ "$(docker ps -q -f name=$MONGO_CONTAINER_NAME)" ]; then
    echo -e "MongoDB container (${GREEN}$MONGO_CONTAINER_NAME${NC}) is running on port $MONGO_PORT"
  else
    echo -e "${RED}Failed to start MongoDB container${NC}"
  fi

  exit 0
}

start_container()
{
    echo -e "${GREEN}Starting existing container: $MONGO_CONTAINER_NAME${NC}"
    docker start $MONGO_CONTAINER_NAME
    echo -e "${GREEN}Started existing container: $MONGO_CONTAINER_NAME${NC}"

    exit 0
}

echo -e "${GREEN}--------SETUP MONGO DB--------${NC}"

# Pull the latest MongoDB image
docker pull $MONGO_IMAGE

# Check if a container with the same name already exists
if [ "$(docker ps -a -q -f name=$MONGO_CONTAINER_NAME)" ]; then
  PS3="Select an option:"
  options=("1: Start the existing container" "2: Exit without changes" "3: Wipe and restart")
  select choice in "${options[@]}"; do
    case $REPLY in
      1)
        start_container
        ;;
      2)
        echo -e "Exiting without changes."
        exit 0
        ;;
      3)
        echo -e "Stopping and restarting the container."
        docker stop $MONGO_CONTAINER_NAME
        docker rm $MONGO_CONTAINER_NAME
        run_fresh_container
        ;;
      *)
        echo -e "${RED}Invalid choice. Please select a valid option.${NC}"
        ;;
    esac
  done
else
  run_fresh_container
fi
