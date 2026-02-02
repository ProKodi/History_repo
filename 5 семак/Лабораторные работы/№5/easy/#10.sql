



SELECT * FROM students
  WHERE students.nuber_course IN (2, 4) AND students.name LIKE "%Петров%"

SELECT * FROM students
  WHERE students.nuber_course IN (2, 4) AND students.name REGEXP("^.*Петров.*$")