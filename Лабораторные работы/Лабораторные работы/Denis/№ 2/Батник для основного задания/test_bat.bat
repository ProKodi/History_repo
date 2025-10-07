rem Для того что бы ос понимала что это скрипт
@echo off

rem 1 Создайте каталог для лабы
md Lab
pause


rem 2 Создайте дерево подкаталогов
cd Lab

md 1 
cd 1
md 2 3
cd 2
md 4
cd ..
cd 3
md 5 6 7
pause


rem 3) В каталоге 1 создайте файл с любым текстом
cd ..
echo Hello, World! > 1.txt
pause


rem 4) Выполните копирование каталога 3 в 2
xcopy "3" "2\3" /s /e /i /y
pause


rem 5) Переместите файлы из каталога 2 в 3
xcopy "2\*" "3" /s /e /i /y
cd 2
rmdir /s /q  3
rmdir /s /q  4
pause



rem 6) Скопируйте в каталог 5 три файла jpg и два doc
cd ..
cd 3
copy "C:\\tmp\\image1.png" "5"
copy "C:\\tmp\\image2.png" "5"
copy "C:\\tmp\\image3.png" "5"
copy "C:\\tmp\\file1.docx" "5"
copy "C:\\tmp\\file2.docx" "5"
pause


rem 7) Просмотрите список файлов директории 5
dir "5"
pause


rem 8) Переименуйте два изображения в wty4.jpg и в k4b.jpg
ren "5\image1.png" "wty4.jpg"
ren "5\image2.png" "k4b.jpg"
pause


rem 9) Переименуйте один из файлов doc в jer4.doc
ren "5\file1.docx" "jer4.docx"
pause

rem 10) Просмотрите список файлов директории 5
dir "5"
pause



rem 11) Скопируйте каталог 5 в 4
xcopy "5\*" "4\5" /E /I
pause


rem 12) Удалите файлы, имя которых заканчивается на "4" из каталога 5
del "5\*4.docx"
del "5\*4.jpg"
pause


rem 13) Просмотрите список файлов директории 5
dir "5"
pause

rem 14) Удалите из каталога 4 все файлы, содержащие в имени "4"
del "4\5\*4*"
pause

rem 15) Просмотрите список файлов директории 7
dir "7"
pause

rem 16) Удалите из каталога 4 все оставшиеся изображения
del "4\5\*.png"
pause

rem 17) Удалите каталог 6
rmdir "6"
pause