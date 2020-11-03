SELECT num_veiculo
	FROM veiculo
	WHERE uf_veiculo = RS;
	
SELECT num_veiculo
	FROM veiculo
	WHERE ano_fabricacao IN \'2012\', \'2014\';
	
SELECT num_veiculo, num_placa
	FROM veiculo
	WHERE ano_modelo = 2014
	ORDER BY data_cadastro;
	