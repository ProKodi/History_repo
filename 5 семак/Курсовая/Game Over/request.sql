



USE `position`;


/* 1 */
select * FROM possessions p
  WHERE p.state = "Выставлен на продажу"
;

/* 2 */
select * FROM possessions p
  WHERE p.city = "Москва"
;

/* 3 */
select r.name, COUNT(*) FROM rieltor r
  LEFT JOIN possessions p 
  ON r.id = p.id_rieltor

  GROUP BY r.id
;

/* 4 */
select c.* FROM customer c
  JOIN type_position tp 
  ON c.id_type = tp.id

  WHERE tp.name = "Квартира"
;

/* 5 */
select * FROM vision v
  WHERE v.id_possetions = 1
;

/* 6 */
select * FROM possessions p
  ORDER BY p.cost DESC
  LIMIT 0, 5
;

/* 7 */
set @CurentDate = Date(NOW()); 


select * FROM `order` o
  WHERE MONTH(date) = MONTH(@CurentDate)
;

/* 8 */
SELECT SUM(p.cost) FROM `order` o
  JOIN possessions p 
  ON o.id_position = p.id
  WHERE o.direction = "Продажа"
;

/* 9 */
SELECT * FROM possessions p
  WHERE NOT EXISTS (
    select * FROM vision v
      WHERE v.id_possetions = p.id
  
  )
;

/* 10 */
select * FROM salesmans s
  WHERE (
    SELECT COUNT(*) FROM possessions p
      WHERE p.state = "Выставлен на продажу" AND p.id_salesmans = s.id
  ) > 1


/* 11 */
INSERT INTO possessions (`adress`, `city`, `square`, `id_type`, `cost`, `id_rieltor`, `state`, `id_salesmans`)
    VALUE ('ул. Малышева, д. 250', 'Екатеринбург', 560.0, 1, 78000, 10, 'Выставлен на продажу', 1)


/* 12 */
UPDATE possessions
  set state = "Продан"
  WHERE id = 1

/* 13 */
select AVG(cost / p.square) FROM possessions p


/* 14 */
SELECT * FROM rieltor r
  WHERE r.id_company IN (
    select id FROM department rc
      WHERE rc.city = "Санкт-Петербург"
  )

/* 15 */
SELECT * FROM customer c
  WHERE (
    select count(*)  FROM vision v
      WHERE v.id_customer = c.id
    ) > 3


/* 16 */
set @AvgCost = (
  SELECT AVG(cost) FROM possessions
);

select * FROM possessions p
  WHERE p.cost < @AvgCost


/* 17 */
DELETE FROM vision 
  WHERE id_possetions IN (
  SELECT id FROM possessions
    WHERE possessions.state = "Снят с продажи"
);

DELETE FROM `order` 
  WHERE id_position IN (
  SELECT id FROM possessions
    WHERE possessions.state = "Снят с продажи"
);

DELETE FROM possessions
  WHERE possessions.state = "Снят с продажи"

/* 18 */
SELECT r.name, COUNT(*) FROM `order` o
  JOIN possessions p
  ON o.id_position = p.id

  JOIN rieltor r 
  ON p.id_rieltor = r.id

  WHERE o.is_successful
  GROUP BY r.id