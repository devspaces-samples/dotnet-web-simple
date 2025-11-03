FROM registry.redhat.io/devspaces/udi-base-rhel10:latest

USER root
ARG INSTALL_PACKAGES="dotnet-hostfxr-9.0 dotnet-runtime-9.0 dotnet-sdk-9.0"

RUN dnf install -y ${INSTALL_PACKAGES}; \
  dnf update -y ; \
  dnf clean all ;

USER 1000
