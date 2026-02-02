



USE student;


SELECT * FROM students
  ORDER BY `group`
  LIMIT 0, 1000 

;


/* or */

USE student;


SELECT * FROM students
  WHERE `group` = "ММ11"
  LIMIT 0, 1000 

;