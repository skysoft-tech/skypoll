ARG VARIANT="ubuntu-20.04"
FROM mcr.microsoft.com/vscode/devcontainers/base:0-${VARIANT}

LABEL org.label-schema.schema-version="1.0" \
      org.label-schema.name="skysoft-tech/devcontainer/skypoll" \
      org.label-schema.vendor="SkySoft.tech" \
      org.label-schema.url="https://skysoft.tech/"

RUN touch /var/log/nohup.log && chown vscode:vscode /var/log/nohup.log && \
    curl -s https://ngrok-agent.s3.amazonaws.com/ngrok.asc | tee /etc/apt/trusted.gpg.d/ngrok.asc > /dev/null && \
    echo "deb https://ngrok-agent.s3.amazonaws.com buster main" | tee /etc/apt/sources.list.d/ngrok.list && \
    apt-get update && apt-get install --no-install-recommends --assume-yes ngrok
