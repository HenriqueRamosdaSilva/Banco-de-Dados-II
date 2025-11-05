CREATE OR REPLACE FUNCTION listar_clientes_acima_30()
RETURNS void AS $$
DECLARE
    c CURSOR FOR 
        SELECT nome, cidade, idade
        FROM clientes
        WHERE idade > 30;
    cliente RECORD;
BEGIN
    -- Abrir o cursor
    OPEN c;
    LOOP
        FETCH c INTO cliente;
        EXIT WHEN NOT FOUND;  
  
        RAISE NOTICE 'Nome: %, Cidade: %, Idade: %', cliente.nome, cliente.cidade, cliente.idade;
    END LOOP;
    
    CLOSE c;
END;
$$ LANGUAGE plpgsql;
