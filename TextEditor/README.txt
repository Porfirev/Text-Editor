Итак эта программа реализует Notepad+


Некоторые особенности в программе (их достаточно много, но как есть):
1. Под простыми текстовыми файлами я понимаю только файл с расширением .txt
2. В моей программе можно открыть несколько файлов одновременно. Однако работу с другим файлом можно начать, только Сохранив или не сохранив файл, с которым вы работаете. 
Т. е. программа не даст работать с двумя не сохранёнными файлами одновременно (в одном окне)
Прошу прощение за неудобства, я слишком поздно узнал, про TabControler. Поэтому у меня просто один RichBox, и на него выводятся разные файлы, но формально я могу работать с несколькими файлами.
3. При выполнении Открытия и Создание файла в новой вкладке выполняется одно и тоже: открывается файл, если такого нет, то создаться.
4. При открытии файла в новом окне, закрыв главное(первое), закроется всё, а также сохраняются для следующего запуска данные именно с этого окна.
Философия в том, что первое окно является главным, иначе не понятно откуда сохранять настройки для следующих запусков.
5. Несколько стилей шрифтов могут быть одновременно, но если вы сделайте жирным вот такой текст ЧЧЧЧККК (4 подчёркнутых символа, и 4 с курсивом), то курсив и подчёркивание пропадут, так как это не общая характеристика всей выделенной части.
6. Всё, что лежит в папке с .exe является частью программы. Пользователь обязуется не редактировать его, даже с помощью Notepad+
7. Чтобы увидеть какие горячие клавиши чему соответствую, то просто наведите на элемент управления (в основном кнопки).
8. Есть элементы с русскими названиями, но они в коде не учавствуют
9. Есть методы где > 40 но это обработчики событий, так что одна логичиская часть
10. ДОП. ФУНКЦИОНАЛА НЕТ


P.S. надеюсь вы любите Смешариков (см. Правка).
