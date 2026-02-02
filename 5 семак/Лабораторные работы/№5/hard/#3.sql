



USE student;

-- По хорошему можно было ограничится только вот этим (тут все равно есть список всех спец)
-- SELECT name, `describe` FROM specialties


/* 
SELECT id_specialty, COUNT(*) FROM students
  GROUP BY id_specialty

*/

SELECT name, `describe`, IFNULL(swc.cout_sp, 0) AS count_student FROM specialties
  LEFT JOIN(
    SELECT id_specialty, COUNT(*) AS cout_sp FROM students
      GROUP BY id_specialty
    ) AS swc
  ON specialties.id = swc.id_specialty
  LIMIT 0, 1000


;