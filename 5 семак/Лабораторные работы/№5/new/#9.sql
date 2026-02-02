



USE student;


SELECT ((YEAR(birthday) DIV 100) + 1), COUNT(*)  FROM students
  GROUP BY ((YEAR(birthday) DIV 100) + 1)
;
