



/*

USE student;


SELECT id_discipline, AVG(mark) AS avg_mark  FROM exams
  GROUP BY id_discipline

;

*/


USE student;


SELECT name, groped_disciplines.avg_mark  FROM disciplines
  INNER JOIN (
    SELECT id_discipline, AVG(mark) AS avg_mark  FROM exams
      GROUP BY id_discipline
  ) AS groped_disciplines
  ON id = groped_disciplines.id_discipline
  LIMIT 0, 1000

;