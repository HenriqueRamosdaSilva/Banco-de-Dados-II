CREATE OR REPLACE FUNCTION listar_clientes_por_cidade_e_idade(cidade_p TEXT, idade_min INT)
RETURNS void AS $$
DECLARE
    c CURSOR FOR
        SELECT nome, cidade, idade
        FROM clientes
        WHERE cidade = cidade_p AND idade >= idade_min;
    cliente RECORD;
BEGIN
    OPEN c;
    LOOP
        FETCH c INTO cliente;
        EXIT WHEN NOT FOUND; 
        RAISE NOTICE 'Nome: %, Cidade: %, Idade: %', cliente.nome, cliente.cidade, cliente.idade;
    END LOOP;
    CLOSE c;
END;
$$ LANGUAGE plpgsql;
