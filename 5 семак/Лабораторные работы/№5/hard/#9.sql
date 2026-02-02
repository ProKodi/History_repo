



USE student;

/* select * FROM students  */

/* SELECT * FROM disciplines   */

/*
SELECT id_discipline, MAX(mark) AS max_mark FROM exams
  GROUP BY id_discipline

*/

/*
SELECT id_discipline, MAX(mark) AS max_mark FROM exams
  INNER JOIN (SELECT * FROM disciplines) AS sl_dicp
  ON sl_dicp.id = exams.id_discipline

  GROUP BY id_discipline
*/

/*
select id_discipline, MAX(mark) FROM exams
  GROUP BY id_discipline

  WHERE mark = (
    SELECT MAX(mark) FROM exams
      WHERE exams.id_discipline = id
  )


*/


SELECT disciplines.name, students.name, mark FROM exams
  INNER JOIN disciplines 
  ON disciplines.id = exams.id_discipline

  INNER JOIN students
  ON students.id = exams.id_student

  WHERE mark = (
    SELECT MAX(mark) FROM exams AS exams_for_where
      WHERE exams_for_where.id_discipline = exams.id_discipline
  )
  LIMIT 0, 1000



;
;