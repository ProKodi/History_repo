



/*

USE student;


SELECT id_discipline, AVG(mark) AS avg_mark  FROM exams
  GROUP BY id_discipline

;

*/


USE student;



/*

SELECT id_discipline, AVG(mark) AS avg_mark  FROM exams
  GROUP BY id_discipline

*/

SELECT name, groped_disciplines.avg_mark FROM disciplines
  LEFT JOIN (
    SELECT id_discipline, AVG(mark) AS avg_mark  FROM exams
      GROUP BY id_discipline
  ) AS groped_disciplines
  ON disciplines.id = groped_disciplines.id_discipline
  LIMIT 0, 1000

;