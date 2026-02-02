



USE student;


/* SELECT * FROM disciplines */

/* SELECT * FROM exams */




SELECT disciplines.name, IFNULL(COUNT(*), 0)  FROM exams 
  LEFT JOIN disciplines
  ON exams.id_discipline = disciplines.id

  GROUP BY disciplines.name
  
  LIMIT 0, 1000

;