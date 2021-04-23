-- INSERT 

INSERT INTO tb_SistemaViario (idSV, tipoSV) VALUES (1, 'Buraco no pavimento');
INSERT INTO tb_SistemaViario (idSV, tipoSV) VALUES (2, 'Via não pavimentada');
INSERT INTO tb_SistemaViario (idSV, tipoSV) VALUES (3, 'Problema com a drenagem na via');
INSERT INTO tb_SistemaViario (idSV, tipoSV) VALUES (4, 'Semáforo desligado');
INSERT INTO tb_SistemaViario (idSV, tipoSV) VALUES (5, 'Falta de sinalização');

INSERT INTO tb_IluminacaoPublica (idIP, tipoIP) VALUES (1, 'Iluminação queimada');
INSERT INTO tb_IluminacaoPublica (idIP, tipoIP) VALUES (2, 'Falta de Iluminação');

INSERT INTO tb_StatusDominio (idDominio, situacao) VALUES (1, 'Pendente');
INSERT INTO tb_StatusDominio (idDominio, situacao) VALUES (2, 'Em análise');
INSERT INTO tb_StatusDominio (idDominio, situacao) VALUES (3, 'Concluída');

-- UPDATE

UPDATE tb_SistemaViario SET tipoSV = 'Buraco no pavimento' WHERE idSV = 1;
UPDATE tb_IluminacaoPublica SET tipoIP = 'Falta de Iluminação' WHERE idIP = 2;
UPDATE tb_StatusDominio SET situacao = 'Concluída' WHERE idDominio = 3;
UPDATE tb_Reclamacao SET observacao = 'Falta de drenagem provoca inundação' WHERE idSV = 3;
UPDATE tb_SistemaViario SET tipoSV = 'Falta de sinalização' WHERE idSV = 5;

-- DELETE

DELETE FROM tb_SistemaViario WHERE idSV = 1;
DELETE FROM tb_SistemaViario WHERE tipodSV LIKE '%pav%';
DELETE FROM tb_IluminacaoPublica WHERE idIP > 0;
DELETE FROM tb_Reclamacao WHERE idIP IS NULL;
DELETE FROM tb_StatusDominio WHERE situacao IN ('Pendente', 'Em análise');

-- SELECT

SELECT COUNT (idSV) FROM tb_SistemaViario WHERE tipoSV = 'Via não pavimentada';
SELECT idDominio FROM tb_StatusDominio WHERE situacao = 'Pendente';
SELECT * FROM tb_IluminacaoPublica WHERE idIP < 2;
SELECT idRec, observacao FROM tb_Reclamacao WHERE idIP IS NULL;
SELECT idRec, observacao FROM tb_Reclamacao WHERE idSV IS NOT NULL AND idIP > 3;
SELECT * FROM tb_StatusDominio ORDER BY situacao ASC;
SELECT tipoIP FROM tb_IluminacaoPublica LIMIT 0,3;
SELECT sv.tipoSV rec.idSV FROM tb_SistemaViario sv INNER JOIN tb_Reclamacao rec ON rec.idSV = sv.idSV);
SELECT ip.tipoIP rec.idIP FROM tb_IluminacaoPublica ip INNER JOIN tb_Reclamacao rec ON rec.idIP = ip.idIP);
SELECT sd.situacao st.idDominio FROM tb_StatusDominio sd INNER JOIN tb_Status st ON sd.idDominio = sv.idDominio);
SELECT st.dataStatus rec.idRec FROM tb_Status st INNER JOIN tb_Reclamacao rec ON rec.idRec = st.idRec);
SELECT sv.idSV rec.idSV FROM tb_SistemaViario sv INNER JOIN tb_Reclamacao rec ON rec.idSV = sv.idSV);