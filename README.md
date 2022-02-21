# UNIVERSIDADE PAULISTA – UNIP EaD
Projeto Integrado Multidisciplinar

Curso Superior de Tecnologia

MARIANA CARDOSO DE BARROS – RA: 0570067

SISTEMA DE RESERVAS DE EQUIPAMENTOS DE MULTIMÍDIA

Projeto Integrado Multidisciplinar
para obtenção do título de graduação em
Análise e Desenvolvimento de Sistemas
apresentado à Universidade Paulista –
UNIP EaD.

Maceió – AL

## RESUMO
A tecnologia de software constitui uma ferramenta essencial na sociedade
proporcionando diversos benefícios como exemplo a organização automatizada de
determinadas tarefas de uma empresa com a finalidade de obter melhores resultados
nos trabalhos realizados minimizando as possíveis falhas humanas. Nesse contexto,
o presente projeto tem como objetivo compor parte da avaliação das matérias de
Projeto de Interface com o Usuário, Programação Orientada a Objetos, Engenharia
de Software e Economia e Mercado integrando o aprendizado e aplicando os
conhecimentos adquiridos em uma situação real; para tal fim, será elaborado um
sistema de reservas de equipamentos contextualizado no cenário de uma escola que
pretende obter, através de um sistema automatizado, um melhor aproveitamento dos
recursos de mídia da instituição a fim de excluir o registro manual dos usuários. O
projeto será fundamentado nos modelos de qualidade da engenharia de software
MPS.BR e será aplicado recursos de classes, encapsulamento, herança e
polimorfismo.

Palavra-chave: Programação, Sistema de Reservas, Software, MPS.BR.


## ABSTRACT

Software technology is an essential tool in society, providing several benefits,
such as the automated organization of certain tasks of a company with the purpose of
obtaining better results in the work performed, minimizing possible human failures. In
this context, the present project aims to compose part of the evaluation of the subjects
of User Interface Design, Object Oriented Programming, Software Engineering and
Economics and Market, integrating the learning and applying the acquired knowledge
in a real situation; for this purpose, an equipment reservation system will be developed,
contextualized in the context of a school that intends to obtain, through an automated
system, a better use of the institution's media resources in order to exclude the manual
registration of users. The project will be based on the quality models of the MPS.BR
software engineering and will apply class, encapsulation, inheritance and
polymorphism resources.

Keyword: Programming, Reservation System, Software, MPS.BR


## INTRODUÇÃO

A era da informação trouxe para o mundo contemporâneo a exigência de se
adaptar aos avanços tecnológicos e um dos espaços afetados por essa mudança foi
a sala de aula que demanda ambientes interativos de aprendizagem para conectar
professor e aluno aos diversos ambientes que a tecnologia da informação pode
proporcionar. No que se refere ao projeto político pedagógico as Diretrizes
Curriculares Nacional da Educação Básica define a utilização de mídias:

- Concretamente, o projeto político-pedagógico das unidades escolares que ofertam o Ensino Médio deve considerar: VIII – utilização de diferentes mídias como processo de dinamização dos ambientes de aprendizagem e construção de novos saberes; (Diretrizes Curriculares Gerais Nacionais da Educação Básica, 2013 - Projetos Políticos Pedagógicos - Cap. VIII. p. 178).

Nesse contexto, o Colégio Vencer Sempre possui um número de
equipamentos de multimídia em que os funcionários da escola fazem uso em suas
atividades de ensino, porém o registro da reserva dos aparelhos é realizado de forma
obsoleta permitindo gargalos no processo. O propósito da escola é resolver estes
problemas investindo em um sistema de registro de reservas a fim de aperfeiçoar o
trabalho dos professores que tornarão suas aulas mais dinâmicas e interativas através
dos recursos multimídia que a escola oferece.

Este trabalho irá abordar todo o processo de construção do sistema desde a
realização do projeto à sua implementação. Determinará os agentes econômicos, o
investimento e tempo necessários, os requisitos de sistema, a aplicação dos conceitos
de projeto de interface e programação orientada à objetos, e os casos de teste.

### 1. Viabilidade
A utilização de um sistema manual de agendamento causa prejuízo de tempo
e dinheiro ao colégio, ao analisar esse contexto fica evidente que a implantação trará
benefícios em todas os setores, tanto da administração que terá fácil acesso aos
dados de agendamento, quanto aos profissionais que irão utilizar os equipamentos
que terão o tempo de agendamento otimizado e não enfrentarão dificuldades de
comunicação pois um sistema automatizado diminuirá significativamente erros
humanos, quanto para o setor financeiro que terá uma administração de danos mais
potencializada pois conseguirá mapear os danos, as causas, e elaborar de forma mais
planejada conserto ou substituição do equipamento e também aos alunos que terão
aulas mais interativas, dinâmicas e acessíveis a nova realidade social.

### 2. Agentes Econômicos

Os agentes econômicos compõem as famílias e a empresa que possuem uma
relação cíclica e de interdependência para seu funcionamento. Nas relações de
negócio empresa-cliente os agentes econômicos terão papel direto e indireto.
As famílias atuarão diretamente com as empresas como ofertante de mão de
obra (programadores, engenheiros de software, e demais profissionais e compõem
uma empresa), recurso para a produção dos bens (matéria-prima e capital) e também
como consumidora do bem.

No trecho a seguir Vasconcellos e Garcia, define os agentes econômicos e os
relaciona aos fatores de produção e ao consumo de bens e serviços:

- Os agentes econômicos são as famílias (unidades familiares) e as empresas
(unidades produtoras). Numa economia de mercado, as famílias são
proprietárias dos fatores de produção e os fornecem às unidades de produção
(empresas) no mercado dos fatores de produção. As empresas combinam
fatores de produção, produzem bens e serviços e os fornecem às famílias no
mercado de bens e serviços. Os fatores de produção básicos são a mão de
obra, a terra e o capital. (VASCONCELLOS, GARCIA, 2014)

De acordo com o trecho acima podemos demonstrar a empresa criadora do
software como um dos agentes econômicos do grupo de empresas, sua mão de obra
ou corpo de colaboradores como um dos fatores de produção se encaixam no grupo
das famílias que por sua vez atuam também como os consumidores (professores,
coordenadores, etc.).

### 3. Prazo de Conclusão e Investimento

Dispondo da compreensão de que a empresa desenvolvedora do software em
questão é nova no mercado e de pequeno porte, o cálculo de tempo e investimento
será baseado nessas informações. Estima-se que serão necessários 4 meses para
todo o processo e investimento de R$ 30.000,00 entendendo que a empresa dispõe
de um pequeno corpo de colaboradores para produzir o software e todos os ciclos do
desenvolvimento como, análise dos requisitos, desenvolvimento do software, roteiros
de teste e implementação do produto.

### 4. Análise de Requisitos

De acordo com Sommerville (2007, p.79) “os requisitos de um sistema são
descrições dos serviços fornecidos pelo sistema”.

#### 4.1. Requisitos Funcionais e Regras de Negócio

- O sistema deve ter um usuário com nome admin que será o
administrador e que poderá visualizar e imprimir relatórios de todos os
agendamentos, incluir e remover equipamentos;

- Permitir que seja cadastrado, removido e alterado professores com
os seguintes dados: nome, e-mail, telefone, disciplina, senha;

- Permitir a inclusão, visualização, alteração de equipamentos de
mídia contendo a descrição do código de cada um dos equipamentos;

- Permitir o processo de agendamento, retirada e devolução do
equipamento. Deve conter data e hora de retirada e data e hora de devolução,
nome do professor, disciplina, código do equipamento, turno;

- Exibir o agendamento realizado.

![carbarrosmari](https://user-images.githubusercontent.com/85528965/154871227-e9820741-2a79-4dee-8f10-bc16750715a2.png)

Fonte: O Autor, 2021.

![carbarrosmari](https://user-images.githubusercontent.com/85528965/154871235-8a50f3aa-b9fd-45ee-b03f-9b9680455d46.png)

Fonte: O Autor, 2021.

![carbarrosmari](https://user-images.githubusercontent.com/85528965/154871244-fb5c0839-3b9f-4ed0-9c27-2a90a2b53235.png)

Fonte: O Autor, 2021.

![carbarrosmari](https://user-images.githubusercontent.com/85528965/154871251-7beccd93-be71-4f7a-bd9b-0c4d4082dc51.png)

Fonte: O Autor, 2021.

![carbarrosmari](https://user-images.githubusercontent.com/85528965/154871255-23f77f06-7531-4237-845c-c825cd501b4a.png)

Fonte: O Autor, 2021.


### 4.2. Requisitos Não-Funcionais
####4.2.1. Requisitos de Produtos

- Usabilidade: o sistema deve ser de fácil utilização.
- Caixas de diálogo se comunicando com o usuário.

![carbarrosmari](https://user-images.githubusercontent.com/85528965/154871267-15b77ffa-2da8-41bc-8118-fb79fee14c25.png)

Fonte: O Autor, 2021.

![carbarrosmari](https://user-images.githubusercontent.com/85528965/154871271-98d87da1-0636-43ec-bfce-f06412ff07d3.png)

Fonte: O Autor, 2021.


- Portabilidade: o sistema deve permitir ser executado em qualquer
plataforma.
- Segurança: o sistema deve possuir autenticação de usuário.

![carbarrosmari](https://user-images.githubusercontent.com/85528965/154871275-4fb28c49-2901-4af5-9eb7-8af9700acd1a.png)

Fonte: O Autor, 2021.

#### 4.2.2. Requisitos Organizacionais
Requisitos de implementação: o sistema deverá ser desenvolvido em
linguagem C#.

#### 4.2.3. Requisitos Externos
Requisitos de interoperabilidade: o sistema deverá se comunicar com o
banco SQL Server.

![carbarrosmari](https://user-images.githubusercontent.com/85528965/154871283-a81b355c-e90b-443f-9e2a-e2b333c8b6f4.png)

Fonte: O Autor, 2021.

Requisitos legais: o sistema deve atender à norma MPS.BR.

### 5. Metodologia de Qualidade
A qualidade do produto de software é um processo que exige inúmeras etapas,
e a garantia da qualidade resulta da capacitação dos processos. De acordo com
Sommerville (2007, p.16) “[...] o processo QA está, principalmente, relacionado à
definição e seleção de padrões que devem ser aplicados ao processo de
desenvolvimento de software e ao produto de software.”.

No objetivo de oferecer um produto de software de qualidade e melhorar o
processo produtivo é necessário que uma empresa de desenvolvimento de software
adote uma metodologia de qualidade para guiar o seu processo de desenvolvimento
em todos os ciclos buscando sempre o melhor método que se adeque à realidade da
empresa e a de seus desenvolvedores.

Considerando que a implementação de normas de qualidade com padrões
internacionais é de alto custo e de longo prazo de adequação optou-se por adotar o
modelo MPS.BR uma vez que “os modelos MPS estão em consonância com as
principais abordagens internacionais para definição, avaliação e melhoria de
processos.” (SOFTEX, 2021 p.). A adoção da norma pelas micro, pequenas e médias
empresas brasileiras inserem-nas no mesmo nível competitivo de grandes empresas
e também possibilita a participação em licitações nacionais visto que o governo
brasileiro usa tal norma como referência, porém mesmo estando em conformidade
com padrões internacionais seu reconhecimento tem abrangência estritamente
nacional.

O modelo MPS.BR foi elaborado com base nas normas ISSO/IEC 12207,
ISSO/IEC 15504 (SPICE) – contribuindo para definição de terminologias, definição de
processos e modelos de avaliação – e o modelo CMMI – contribuindo principalmente
para a avaliação de processo e modelos de maturidade.

A estrutura do MPS.BR está subdividida em 4 componentes, 19 processos
distribuídos em 7 níveis de maturidade. Os níveis de maturidade demonstram um
indicativo de evolução da qualidade definindo em cada estágio um processo de
maturação específico. Os níveis de maturidade de forma crescente são
respectivamente: G – parcialmente gerenciado; F – gerenciado; E – parcialmente
definido; D – largamente definido; C – definido; B – gerenciado quantitativamente; A –
otimizado. Definir níveis de maturidade e os processos para atingi-lo possibilita uma
implementação mais gradual e adequada às micro, pequenas e médias empresas.

### 6. Sistema Orientado à Objetos
Orientação à Objetos é um modelo de programação de software com base na
interação de unidades (objetos) que são definidos por modelos (classes). Sua principal
característica é a possibilidade de reuso de código juntamente com a manutenção.
Quando um código reutilizado diversas vezes em um programa for alterado ele será
alterado em todo o programa não havendo necessidade de gastar tempo realizando
novamente a mesma alteração em outras partes do programa que o código foi
reutilizado.
#### 6.1. Classes e Objetos
O conceito de classe e objeto é bastante próximo a filosofia de Platão
sobre o mundo das ideias e o mundo dos sentidos. Segundo Platão no mundo
das ideias existe o conceito primordial de determinado objeto e o mundo dos
sentidos seria a forma concreta do objeto do mundo das ideias.

Na Orientação à Objeto, o conceito de classe e objeto pode ser
exemplificado com a seguinte analogia: um carro ele tem sempre as mesmas
funções, tem a mesma forma e o mesmo conceito universal (carro), mas cada
carro tem suas particularidades, como cor, tipo de mala, potência do motor,
essas características vão determinar o objeto.

![carbarrosmari](https://user-images.githubusercontent.com/85528965/154871293-912babd4-3389-44dc-8e45-5bcc7951e9f5.png)

Fonte: O Autor, 2021.

Acima exemplifico em código C# como criar classes e determinar seus
atributos. Neste caso a classe Pessoa recebe os atributos Nome, E-mail,
Telefone, Disciplina, Senha.

A imagem anterior mostra o exemplo de instância de um objeto. Foi
instanciado o objeto janelaCadastro a partir da classe Cadastro.


#### 6.2. Herança
O conceito de herança é próximo a ideia de parentesco. Um filho herda
determinadas características dos pais. Da mesma forma, uma classe B pode
obter características da classe A mãe.
Classes criadas para o projeto:

![carbarrosmari](https://user-images.githubusercontent.com/85528965/154871300-9396ae4e-f022-4e0d-b129-5e2e639a0762.png)

Fonte: O Autor, 2021.

![carbarrosmari](https://user-images.githubusercontent.com/85528965/154871304-28c22bad-ff47-4f50-9cfe-d2898d69adcc.png)

Fonte: O Autor, 2021.

![carbarrosmari](https://user-images.githubusercontent.com/85528965/154871311-c8b53efd-e8e5-4414-a6b0-4b05d8a8b90b.png)

Fonte: O Autor, 2021.

#### 6.3. Polimorfismo
A palavra polimorfismo vem do grego – poli = muitas, morphos = forma
– e seu conceito quer dizer muitas formas. Desta forma, um objeto pode se
comportar de várias formas. Por exemplo, um carro que roda apenas a álcool,
não irá funcionar com gasolina, mas um carro. flex irá.

### 7. Testes

![carbarrosmari](https://user-images.githubusercontent.com/85528965/154871318-17eb5970-e68b-4aab-8903-bf4a58e86211.png)

Fonte: O Autor, 2021.

![carbarrosmari](https://user-images.githubusercontent.com/85528965/154871322-5b10d37f-080e-4bfb-ace7-234eb72b2022.png)

Fonte: O Autor, 2021.

![carbarrosmari](https://user-images.githubusercontent.com/85528965/154871327-10763c36-571e-423e-8ec1-86730447c787.png)

Fonte: O Autor, 2021.

![carbarrosmari](https://user-images.githubusercontent.com/85528965/154871332-6a82b351-7cdf-4c59-934c-847a018dd610.png)

Fonte: O Autor, 2021.

![carbarrosmari](https://user-images.githubusercontent.com/85528965/154871338-708f8ac6-2aa6-4b2f-9924-130ad36be88c.png)

Fonte: O Autor, 2021.

### 8. Conclusão
O presente trabalho foi realizado como um estudo e aplicação prática dos
conteúdos estudados no curso de análise e desenvolvimento de sistemas da
Universidade Paulista. Nele, foi possível entender de forma prática a aplicação e
integração da programação orientada a objetos, da engenharia de software e da
experiência do usuário com o sistema construído.

Foi possível planejar a construção do software baseando-se em padrões de
qualidade em todos os ciclos de vida, desde a analise de requisitos à implementação
do sistema.

A aplicação dos conceitos da programação orientada à objetos através da
construção do software na linguagem C# possibilitou a experiência com a linguagem
e a plataforma Visual Studio, proporcionando o entendimento da aplicação dos
conceitos de encapsulamento, herança, polimorfismo, classes e objetos utilizando a
linguagem C# e praticando programação voltada a experiência do usuário, utilizando
assim a analise de requisitos para a construção do sistema.

Através da análise das regras de negócio foi possível compreender de que
formas os aspectos econômicos interagem e possibilitam a construção de um software
de qualidade.

De tal modo foi possível compreender e experienciar da realidade do
desenvolvedor que participa de cada processo do ciclo de vida do software

## REFERÊNCIAS

BRASIL. Diretrizes Curriculares Gerais Nacionais da Educação Básica. In: Brasil.
Ministério da Educação. Secretaria de Educação Básica. Diretoria de Currículos e
Educação Integral. Brasília: MEC, SEB, DICEI, 2013. p. 178.

SOMMERVILLE, I. Engenharia de software. 8. ed. São Paulo: Pearson Prentice Hall,
2007.

SOFTEX. Guia Geral do MPS.BR, 2020. Disponível em:
https://softex.br/download/guia-geral-de-software-2021/. Acesso em 11 Abr 2021.

VASCONCELOS, Marco Antônio S.; GARCIA, Manuel E. Fundamentos de
economia. 5. ed. São Paulo: Saraiva, 2014.
