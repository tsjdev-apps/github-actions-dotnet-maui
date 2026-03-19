# GitHub Actions for .NET MAUI

This repository is intended as a collection of GitHub Actions workflows and supporting examples for building .NET MAUI applications in CI/CD.

At the moment, the repository contains one workflow focused on Android builds:

- Build a .NET MAUI Android app on `windows-latest`
- Restore dependencies and install the MAUI workload
- Decode a signing keystore from GitHub Secrets
- Produce signed Android artifacts (`.aab` and `.apk`)
- Upload the build output as a GitHub Actions artifact

The sample application in `src/` exists to support and validate that workflow.

This is only the starting point. More workflows and automation examples for .NET MAUI platforms and release scenarios will be added over time.
