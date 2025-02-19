//namespace CSharpGeral.AssinarBrad
//{
//    //internal class Main
//    //{
//    //};
//    //        // Caminho do arquivo onde o JWT será armazenado
//    //        string jwtFilePath = "Z:\\Programacao\\C#_Geral\\CSharpGeral\\jwt_homolog.txt";

////        File.WriteAllText(jwtFilePath, "");

////            // Gera um JWT e salva no arquivo especificado
////            string JWTPuro = GenerateJwt(jwtFilePath, "c8fe651e-cdd1-46cb-8d89-aa7f096aa22b",
////                "https://proxy.api.prebanco.com.br/auth/server/v1.1/token");

////        // Caminho da chave privada usada para assinar o JWT
////        string privateKeyPath = "C:\\Users\\vgabr\\OneDrive\\Desktop\\CS\\CSAPIBRADESCO\\dfix.homologacao.key.pem";

////        // Lê o conteúdo do JWT gerado
////        string jwtContent = File.ReadAllText(jwtFilePath);

////        // Assina o JWT usando a chave privada e retorna a assinatura em Base64
////        string base64Signature = SignJwt(jwtContent, privateKeyPath);

////        // Concatena o JWT com a assinatura para formar um JWS
////        string JWS = jwtContent + "." + base64Signature;

////        // Salva o JWS no arquivo especificado
////        File.WriteAllText(jwtFilePath, JWS);



////            string body = @"{""registraTitulo"":1,""nuCPFCNPJ"":""31759488"",""filialCPFCNPJ"":""0"",""ctrlCPFCNPJ"":""55"",""cdTipoAcesso"":2,""clubBanco"":0,""prazoDecurso"":10,""cdTipoContrato"":0,""nuSequenciaContrato"":0,""idProduto"":""9"",""nuNegociacao"":""285600000000222652"",""cdBanco"":237,""nuSequenciaContrato2"":0,""tpRegistro"":1,""cdProduto"":1730,""nuTitulo"":0,""nuCliente"":""WEBSERVICE"",""dtEmissaoTitulo"":""19.09.2024"",""dtVencimentoTitulo"":""20.12.2024"",""tpVencimento"":0,""vlNominalTitulo"":1500,""cdEspecieTitulo"":1,""tpProtestoAutomaticoNegativacao"":0,""prazoProtestoAutomaticoNegativacao"":0,""controleParticipante"":"""",""cdPagamentoParcial"":"""",""qtdePagamentoParcial"":0,""percentualJuros"":0,""vlJuros"":0,""qtdeDiasJuros"":0,""percentualMulta"":0,""vlMulta"":0,""qtdeDiasMulta"":0,""percentualDesconto1"":0,""vlDesconto1"":0,""dataLimiteDesconto1"":"""",""percentualDesconto2"":0,""vlDesconto2"":0,""dataLimiteDesconto2"":"""",""percentualDesconto3"":0,""vlDesconto3"":0,""dataLimiteDesconto3"":"""",""prazoBonificacao"":0,""percentualBonificacao"":0,""vlBonificacao"":0,""dtLimiteBonificacao"":"""",""vlAbatimento"":0,""vlIOF"":0,""nomePagador"":""TESTEREGISTRO"",""logradouroPagador"":""AVENIDACOPACABANA"",""nuLogradouroPagador"":""237"",""complementoLogradouroPagador"":""3ANDAR"",""cepPagador"":""6472"",""complementoCepPagador"":1,""bairroPagador"":""ALPHAVILLE"",""municipioPagador"":""BARUERI"",""ufPagador"":""SP"",""cdIndCpfcnpjPagador"":1,""nuCpfcnpjPagador"":35594132813,""endEletronicoPagador"":"""",""nomeSacadorAvalista"":"""",""logradouroSacadorAvalista"":"""",""nuLogradouroSacadorAvalista"":"""",""complementoLogradouroSacadorAvalista"":"""",""cepSacadorAvalista"":0,""complementoCepSacadorAvalista"":0,""bairroSacadorAvalista"":"""",""municipioSacadorAvalista"":"""",""ufSacadorAvalista"":"""",""cdIndCpfcnpjSacadorAvalista"":0,""nuCpfcnpjSacadorAvalista"":0,""enderecoSacadorAvalista"":""""}";

////        long iat = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
////        string jti = iat.ToString() + "000";


////        GeneratePostRequest(
////                "POST",
////                "/v1/boleto/registrarBoleto",
////                "",
////            body,
////            JWTPuro,
////            jti,
////            privateKeyPath

////            );
////    }
////}


////static string SignJwt(string jwtContent, string privateKeyPath)
////{
////    // Lê a chave privada do arquivo
////    var privateKey = File.ReadAllText(privateKeyPath);

////    // Cria um objeto RSA para realizar a assinatura
////    using RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

////    // Importa a chave no formato PEM para o objeto RSA
////    rsa.ImportFromPem(privateKey.ToCharArray());

////    // Converte o conteúdo do JWT em bytes e assina usando SHA-256 e padding PKCS1
////    byte[] signatureBytes = rsa.SignData(Encoding.UTF8.GetBytes(jwtContent), HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);

////    // Converte a assinatura para Base64
////    string base64Signature = Convert.ToBase64String(signatureBytes);

////    // Retorna a assinatura codificada em Base64
////    return base64Signature;
////}

////public static string GenerateJwt(string jwtTxtPath, string clientId, string tokenUrl)
////{
////    // Lê o payload e o cabeçalho do JWT a partir dos arquivos
////    string header = File.ReadAllText("Z:\\Programacao\\C#_Geral\\CSharpGeral\\jsonHeader.txt");

////    // Definir valores conforme as regras
////    long iat = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
////    long exp = iat + 3600;
////    string jti = iat.ToString() + "000";

////    var tokenData = new
////    {
////        aud = "https://proxy.api.prebanco.com.br/auth/server/v1.1/token",
////        sub = "c8fe651e-cdd1-46cb-8d89-aa7f096aa22b", // clientkey fornecido
////        iat = iat,
////        exp = exp,
////        jti = jti,
////        ver = "1.1"
////    };

////    string jsonPayload = JsonConvert.SerializeObject(tokenData);


////    // Codifica o cabeçalho e o payload em Base64 URL-safe
////    string encodedHeader = Base64UrlEncode(Encoding.UTF8.GetBytes(header));
////    string encodedPayload = Base64UrlEncode(Encoding.UTF8.GetBytes(jsonPayload));

////    // Concatena cabeçalho e payload para formar a parte inicial do JWT
////    string toSign = encodedHeader + "." + encodedPayload;

////    // Salva o JWT parcial no arquivo
////    File.WriteAllText(jwtTxtPath, toSign);

////    return encodedPayload;
////}

////private static string Base64UrlEncode(byte[] input)
////{
////    // Converte os bytes em Base64 padrão
////    string base64 = Convert.ToBase64String(input);

////    // Substitui caracteres para compatibilidade com URLs (+ -> -, / -> _, remove =) e retorna a string formatada
////    return base64.Replace("+", "-").Replace("/", "_").TrimEnd('=');
////}




////private static void GeneratePostRequest(
////    string Metodo,
////    string Endpoint,
////    string Parametros,
////    string Body,
////    string Bearer_Token,
////    string Nonce,
////    string privateKeyPath
////    )
////{
////    string requestBoletoPath = "Z:\\Programacao\\C#_Geral\\CSharpGeral\\requestPostGeraBoleto.txt";

////    string montandoString = Metodo + "\n" + Endpoint + "\n" + Parametros + "\n" + Body + "\n" + Bearer_Token + "\n" + Nonce + "\n" + DateTime.Now + "\nSHA256";

////    File.WriteAllText(requestBoletoPath, montandoString);
////}
////    }
////}

