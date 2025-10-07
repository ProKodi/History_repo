

@echo off

REM Удаление всех файлов с папки флэшки
set "flashDriveFolder=%1"
if exist "%flashDriveFolder%" (
    echo Удаление файлов с папки флэшки...
    for /f "delims=" %%F in ('dir /b "%flashDriveFolder%"') do (
        if exist "%flashDriveFolder%\%%F" del "%flashDriveFolder%\%%F"
    )
) else (
    echo Папка флэшки не найдена.
    goto :eof
)

REM Копирование файлов из каталога DN, имеющих расширение .exe
set "srcFolder=%2"
set "destFolder=%flashDriveFolder%"
echo Копирование файлов из каталога DN...
for /f "delims=" %%F in ('dir /b "%srcFolder%\*.exe"') do (
    copy "%srcFolder%\%%F" "%destFolder%"
)

REM Переименование всех файлов в указанной папке таким образом, что-бы они начинались на букву «а»
echo Переименование файлов...
set "counter=0"
for /f "delims=" %%F in ('dir /b "%flashDriveFolder%"') do (
    set /a "counter+=1"
    ren "%flashDriveFolder%\%%F" "a%counter%.%%F"
)

REM Вывод на экран содержимого файла, имя которого задано как пара-метр
set "fileToDisplay=%3"
if exist "%flashDriveFolder%\%fileToDisplay%" (
    echo Содержимое файла "%fileToDisplay%":
    type "%flashDriveFolder%\%fileToDisplay%"
) else (
    echo Файл не найден.
)

pause