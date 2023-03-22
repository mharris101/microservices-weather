#!/bin/bash
set -e

aws ecr get-login-password --region us-east-1 --profile weather-ecr-agent | docker login --username AWS --password-stdin 748840328402.dkr.ecr.us-east-1.amazonaws.com
docker build -f ./Dockerfile -t cloud-weather-temperature:latest .
docker tag cloudweather-temperature:latest 748840328402.dkr.ecr.us-east-1.amazonaws.com/cloud-weather-temperature:latest
docker push 748840328402.dkr.ecr.us-east-1.amazonaws.com/cloud-weather-temperature:latest
