CREATE OR REPLACE FUNCTION contar_registros_dinamico(tabela_nome TEXT)
RETURNS void AS
$$
DECLARE
    query TEXT;
    c REFCURSOR; 
    registro RECORD;
    total INT := 0;
BEGIN
    query := format('SELECT * FROM %I', tabela_nome);

    OPEN c FOR EXECUTE query;

    LOOP
        FETCH c INTO registro;
        EXIT WHEN NOT FOUND;  
        total := total + 1;
    END LOOP;
    RAISE NOTICE 'Total de registros na tabela %: %', tabela_nome, total;
    CLOSE c;
END;
$$ LANGUAGE plpgsql;
