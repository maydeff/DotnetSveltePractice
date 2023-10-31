#!/bin/bash

# Define variables
POSTGRES_IMAGE="postgres"
POSTGRES_CONTAINER_NAME="my-postgres-demo"
POSTGRES_PORT="5432"
POSTGRES_USER="postgres"
POSTGRES_PASSWORD="postgres"
POSTGRES_DB="test_database"

# ANSI color codes for colored output
GREEN='\033[0;32m'  # Green
RED='\033[0;31m'    # Red
ORANGE='\033[0;33m' # Orange
NC='\033[0m'        # No Color

run_fresh_container() {
  # Run the PostgreSQL container
  echo -e "${GREEN}Starting: $POSTGRES_CONTAINER_NAME${NC}"
  docker run -d -p $POSTGRES_PORT:5432 --name $POSTGRES_CONTAINER_NAME -e POSTGRES_USER=$POSTGRES_USER -e POSTGRES_PASSWORD=$POSTGRES_PASSWORD -e POSTGRES_DB=$POSTGRES_DB $POSTGRES_IMAGE

  # Check if the container is running
  echo -e "${GREEN}Started: $POSTGRES_CONTAINER_NAME${NC}"

  if [ "$(docker ps -q -f name=$POSTGRES_CONTAINER_NAME)" ]; then
    echo -e "PostgreSQL container (${GREEN}$POSTGRES_CONTAINER_NAME${NC}) is running on port $POSTGRES_PORT"
  else
    echo -e "${RED}Failed to start PostgreSQL container${NC}"
  fi

  exit 0
}

start_container() {
  echo -e "${GREEN}Starting existing container: $POSTGRES_CONTAINER_NAME${NC}"
  docker start $POSTGRES_CONTAINER_NAME
  echo -e "${GREEN}Started existing container: $POSTGRES_CONTAINER_NAME${NC}"

  exit 0
}

echo -e "${GREEN}--------SETUP POSTGRE DB--------${NC}"

# Pull the latest PostgreSQL image
docker pull $POSTGRES_IMAGE

# Check if a container with the same name already exists
if [ "$(docker ps -a -q -f name=$POSTGRES_CONTAINER_NAME)" ]; then
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
        docker stop $POSTGRES_CONTAINER_NAME
        docker rm $POSTGRES_CONTAINER_NAME
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
