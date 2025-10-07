


rem 1 Создайте каталог для лабы
md LabZvarg
cd LabZvarg
pause

rem 2 Создайте дерево подкаталогов
md 1 
cd 1
md 2 3 4

cd 2
md 5
cd ..

cd 4
md 6 7

rem 3) В каталоге 1 создайте файл с любым текстом
cd ..
echo Hello, World! This is my text and he is ugly > 1.txt


rem 4) Выполните копирование каталога 3 в 2
xcopy "3" "2\3" /s /e /i /y

rem 5) Переместите файлы из каталога 2 в 3
xcopy "2\*" "3" /s /e /i /y
cd 2
rem  Удаляем каталоги которые мы должны били перенести
rmdir /s /q  3
rmdir /s /q  5
cd ..


rem 6) Скопируйте в каталог 5 три файла jpg и два doc
cd 3
copy "C:\\tmpZvarg\\image1.png" "5"
copy "C:\\tmpZvarg\\image2.png" "5"
copy "C:\\tmpZvarg\\image3.png" "5"
copy "C:\\tmpZvarg\\file1.docx" "5"
copy "C:\\tmpZvarg\\file2.docx" "5"

rem 7) Просмотрите список файлов директории 5
dir "5"

rem 8) Переименуйте два изображения в wty4.jpg и в k4b.jpg
ren "5\image1.png" "wty4.jpg"
ren "5\image2.png" "k4b.jpg"

rem 9) Переименуйте один из файлов doc в jer4.doc
ren "5\file1.docx" "jer4.docx"

rem 10) Просмотрите список файлов директории 5
dir "5"

rem 11) Скопируйте каталог 5 в 4
cd ..
xcopy "3\5\*" "4\5" /E /I

rem 12) Удалите файлы, имя которых заканчивается на "4" из каталога 5
del "3\5\*4.docx"
del "3\5\*4.jpg"

rem 13) Просмотрите список файлов директории 5
dir "3\5"

rem 14) Удалите из каталога 4 все файлы, содержащие в имени "4"
del "4\5\*4*"

rem 15) Просмотрите список файлов директории 7
dir "4\7"

rem 16) Удалите из каталога 4 все оставшиеся изображения
del "4\5\*.png"

rem 17) Удалите каталог 6
rmdir "4\6"