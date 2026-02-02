


USE student;


/*------ 1 ------*/
SELECT * FROM students AS MainStud
  WHERE YEAR(birthday) > (
    SELECT AVG(YEAR(birthday)) AS AvgBith  FROM students
      WHERE nuber_course = MainStud.nuber_course
      GROUP BY nuber_course
  ) 

/*------ 2 ------*/
SELECT * FROM specialties
  WHERE NOT EXISTS(
  SELECT * FROM students
    WHERE students.id_specialty = specialties.id AND students.nuber_course = 5
  )

/*------ 3 ------*/
SELECT * FROM students
  JOIN exams e 
  ON students.id = e.id_student

  WHERE (
    SELECT Max(mark) AS MaxMark FROM exams
      WHERE exams.id_discipline = e.id_discipline
      GROUP BY exams.id_discipline
  ) <= e.mark

/*------ 4 ------*/
SELECT * FROM students s
  WHERE birthday < (
    SELECT MAX(birthday) FROM students
      WHERE students.nuber_course = s.nuber_course
      GROUP BY nuber_course
  )

/*------ 5 ------*/
set @AvgStudentAllSp = (SELECT AVG(cn.cnt) FROM (
    SELECT COUNT(*) AS cnt FROM students s
      GROUP BY s.id_specialty
  ) cn
);

select * FROM specialties
  WHERE (
    SELECT COUNT(*) AS CNT FROM students
      WHERE students.id_specialty = specialties.id
      GROUP BY students.id_specialty
   ) >= @AvgStudentAllSp
;
/*------ 7 ------*/
set @AvgMarkAll = (SELECT AVG(mark) FROM exams e);


SELECT * FROM disciplines d
  WHERE (select AVG(e.mark) FROM exams e
    WHERE d.id = e.id_discipline
    GROUP BY e.id_discipline
  ) > @AvgMarkAll
;


/*------ 6 ------*/
SELECT * FROM students s
  WHERE EXISTS(SELECT * FROM exams
    WHERE (id_student = s.id) AND (mark <= 2)
  )
;



/*------ 8 ------*/
SELECT * FROM students s
  LEFT JOIN exams e 
  ON s.id = e.id_student

  WHERE (SELECT AVG(Mark) FROM exams ex
    WHERE ex.id_discipline = e.id_discipline
    GROUP BY ex.id_discipline
  ) < e.mark
;

/*------ 9 ------*/
set @MaxCountOnSpecialty = (
  SELECT Max(MaxOnSp.cnt) FROM (
    SELECT COUNT(*) AS cnt FROM students s
      GROUP BY s.id_specialty
  ) MaxOnSp
);

SELECT * FROM specialties s
  WHERE (
    SELECT COUNT(*) FROM students s1
      WHERE s1.id_specialty = s.id
      GROUP BY s1.id_specialty
  ) = @MaxCountOnSpecialty


/*------ 10 ------*/

SELECT * FROM students s 
  WHERE NOT EXISTS(SELECT * FROM exams
    WHERE (id_student = s.id) AND (mark <= 2)
  )