
CREATE   PROCEDURE ListarComissoesVendedores
AS

/*
A lista de comissionamento deve ser obtida pela aplicação 
chamando a procedure ListarComissoesVendedores. 
Altere o comportamento desta procedure para obter o resultado esperado

Crie em seu projeto uma tela que exibe uma tabela com o 
valor total a ser comissionado para cada vendedor.

*/
    -- Altere esta procedure para retornar a lista
    -- com o resultado das comissões por vendedor

SELECT
	VND002.IdeVendedor,
	NmeVendedor, 
	QtdVendas = COUNT(*),
	QtdValeCombustivel = SUM(CASE WHEN StaValeCombustivel=1 THEN 1 ELSE 0 END), 
	VlrTotalVendas = SUM(VND002.VlrPrecoVenda),
	VlrTotalComissao = (
		CASE 
		WHEN StaValeCombustivel=1 THEN
			CASE 
				WHEN IdeCombustivel=1 AND SUM((VlrPrecoVenda*0.01) - 200) > 0 THEN
					SUM((VlrPrecoVenda*0.01) - 200) 											
				WHEN IdeCombustivel=2 AND SUM((VlrPrecoVenda*0.01) - 180) > 0 THEN
					SUM((VlrPrecoVenda*0.01) - 180)
				WHEN IdeCombustivel=3 AND SUM((VlrPrecoVenda*0.01) - 150) > 0 THEN
					SUM((VlrPrecoVenda*0.01) - 150)
				ELSE 0
			END
		ELSE
			SUM((VlrPrecoVenda*0.01))
		END)
    FROM VND002_VENDA VND002
	INNER JOIN VND001_VENDEDOR VND001 
		ON VND001.IdeVendedor = VND002.IdeVendedor
    INNER JOIN VEI004_MODELO_VERSAO VEI004
        ON VEI004.IdeModeloVersao = VND002.IdeModeloVersao	
GROUP BY VND002.IdeVendedor,NmeVendedor, StaValeCombustivel, IdeCombustivel