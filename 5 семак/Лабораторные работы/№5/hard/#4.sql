


USE student;


/* SELECT * FROM disciplines */

/* SELECT id_discipline FROM exams */

/*

SELECT id_discipline, COUNT(*) as count_exm_for_disp FROM exams
  GROUP BY id_discipline

*/

SELECT name FROM disciplines
  LEFT JOIN (
    SELECT id_discipline, COUNT(*) as count_exm_for_disp FROM exams
      GROUP BY id_discipline
  ) AS cde
  ON cde.id_discipline = disciplines.id
  WHERE cde.count_exm_for_disp IS NULL
  LIMIT 0, 1000



;