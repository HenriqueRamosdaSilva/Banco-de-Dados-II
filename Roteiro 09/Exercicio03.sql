CREATE OR REPLACE FUNCTION listar_vendas_acima_500()
RETURNS void AS $$
DECLARE
    c CURSOR FOR
        SELECT c.nome AS cliente, v.valor, v.dt_venda
        FROM vendas v
        JOIN clientes c ON v.cliente_id = c.id
        WHERE v.valor > 500;
    venda RECORD;
BEGIN
    OPEN c;
    
    LOOP
        FETCH c INTO venda;
        EXIT WHEN NOT FOUND;  
        
        RAISE NOTICE 'Cliente: %, Valor: R$ %, Data: %', venda.cliente, venda.valor, venda.dt_venda;
    END LOOP;
    
    CLOSE c;
END;
$$ LANGUAGE plpgsql;
