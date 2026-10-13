#!/usr/bin/env bash
set -euo pipefail

echo "[bootstrap] starting"

if [[ -f package.json ]]; then
  echo "[bootstrap] npm project detected"
  if [[ -f package-lock.json ]]; then
    npm ci
  else
    npm install
  fi
fi

if [[ -f requirements.txt ]]; then
  echo "[bootstrap] python requirements detected"
  python -m pip install --upgrade pip
  python -m pip install -r requirements.txt
fi

if [[ -f .pre-commit-config.yaml ]]; then
  echo "[bootstrap] enabling pre-commit"
  python -m pip install pre-commit
  pre-commit install
fi

echo "[bootstrap] done"

# --- added: check for dotnet SDK ---
if ! command -v dotnet >/dev/null 2>&1; then
  echo "WARNING: .NET SDK (dotnet) not found on PATH."
  echo "Install from https://dotnet.microsoft.com/download and re-run this script."
else
  echo "dotnet version: $(dotnet --version)"
fi
# --- end added ---
