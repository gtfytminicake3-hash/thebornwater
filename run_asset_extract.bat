@echo off
echo =========================================
echo Asset Extraction Automation
echo =========================================
echo This script uses python and UnityPy to extract assets.
python -c "import UnityPy" 2>nul
if errorlevel 1 (
    echo [ERROR] UnityPy is not installed!
    echo Please run: pip install UnityPy
    pause
    exit /b 1
)

python extract_unity_assets.py
pause
