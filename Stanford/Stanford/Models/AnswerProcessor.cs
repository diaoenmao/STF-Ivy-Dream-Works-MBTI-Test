using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Stanford.Context;
using System.Data.Entity;

namespace Stanford.Models
{
    public class AnswerProcessor
    {
        QuestionContext questionContext = new QuestionContext();
        
        public int Id { get; set; }
        public int E = 0;
        public int I = 0;
        public int S = 0;
        public int N = 0;
        public int T = 0;
        public int F = 0;
        public int J = 0;
        public int P = 0;
        public string[] arr = new string[4];
        public List<String> process(AnswerList answerList)
        {
            DbSet<ChrTrait> traits = questionContext.Traits;
            List<Answer> alist = answerList.getList();
            this.calculate(alist);
            arr[0] = (I >= E) ? "I" : "E";
            arr[1] = (N >= S) ? "N" : "S";
            arr[2] = (F >= T) ? "F" : "T";
            arr[3] = (P >= J) ? "P" : "J";
            String result = String.Join("", arr);
            List<String> output = new List<String>();
            output.Add(result);
            if (result.Equals("ISTJ"))
            {
                output.Add(
                       "1.严肃、安静、藉由集中心 志与全力投入、及可被信赖获致成功。<br />" +
                       "                2.行事务实、有序、实际 、 逻辑、真实及可信赖。<br />" +
                       "                3.十分留意且乐于任何事（工作、居家、生活均有良好组织及有序。<br />" +
                       "                4.负责任。<br />" +
                       "                5.照设定成效来作出决策且不畏阻挠与闲言会坚定为之。<br />" +
                       "                6.重视传统与忠诚。<br />" +
                       "                7.传统性的思考者或经理。");
                output.Add("工商业领域、政府机构金融银行业、政府机构、技术领域、医务领域");

                output.Add("<div class=\"job\">审计师、会计、财务经理、办公室行政管理、后勤和供应管理、中层经理、公务（法律、税务）执行人员等；银行信贷员、成本估价师、保险精算师、税务经纪人、税务检查员等；机械、电气工程师、计算机程序员、数据库管理员、地质、气象学家、法律研究者、律师等；外科医生、药剂师、实验室技术人员、牙科医生、医学研究员等");

                
                
                

                return output;
            }
            else if (result.Equals("ISFJ"))
            {
                output.Add(
                       "1.安静、和善、负责任且有良心。<br />" +
                       "                2.行事尽责投入。<br />" +
                       "                3.安定性高，常居项目工作或团体之安定力量。<br />" +
                       "                4.愿投入、吃苦及力求精确。<br />" +
                       "                5.兴趣通常不在于科技方面。对细节事务有耐心。<br />" +
                       "                6.忠诚、考虑周到、知性且会关切他人感受。<br />" +
                       "                7.致力于创构有序及和谐的工作与家庭环境。");
                output.Add("无明显领域特征、医护领域、消费类商业、服务业领域");
                output.Add("行政管理人员、总经理助理、秘书、人事管理者、项目经理、物流经理、律师助手等；外科医生及其它各类医生、家庭医生、牙科医生、护士、药剂师、医学专家、营养学专家、顾问等；零售店、精品店业主、大型商场、酒店管理人员、室内设计师等");
                return output;
            }
            else if (result.Equals("INFJ"))
            {
                output.Add(
                       "1.因为坚忍、创意及必须达成的意图而能成功。<br />" +
                       "                2.会在工作中投注最大的努力。<br />" +
                       "                3.默默强力的、诚挚的及用心的关切他人。<br />" +
                       "                4.因坚守原则而受敬重。<br />" +
                       "                5.提出造福大众利益的明确远景而为人所尊敬与追随。<br />" +
                       "                6.追求创见、关系及物质财物的意义及关联。<br />" +
                       "                7.想了解什么能激励别人及对他人具洞察力。<br />" +
                       "                8.光明正大且坚信其价值观。<br />" +
                       "                9.有组织且果断地履行其愿景。");
                output.Add("咨询、教育、科研等领域文化、艺术、设计等领域");

                ChrTrait INFJ = traits.Find(1);
                List<String> jobs = INFJ.jobsStr.Split(',').ToList<String>();
                String resultStr = "";
                foreach (String job in jobs){
                    resultStr = String.Concat(resultStr, "<div id=\"" + job + "\" class=\"job\" onmousedown=\"showMajor(true, \'" + job + "\');\">" + job + "   </div>");
                }
                output.Add(resultStr);
                return output;
            }
            else if (result.Equals("INTJ"))
            {
                output.Add(
                      "1.具强大动力与本意来达成目的与创意—固执顽固者。<br />" +
                      "                2.有宏大的愿景且能快速在众多外界事件中找出有意义的模范。<br />" +
                      "                3.对所承负职务，具良好能力于策划工作并完成。<br />" +
                      "                4.具怀疑心、挑剔性、独立性、果决，对专业水准及绩效要求高。");
                output.Add("科研、科技应用技术咨询、管理咨询、金融、投资领域、创造性行业");
                output.Add("各类科学家、研究所研究人员、设计工程师、系统分析员、计算机程序师、研究开发部经理等；各类技术顾问、技术专家、企业管理顾问、投资专家、法律顾问、医学专家、精神分析学家等；经济学家、投资银行研究员、证券投资和金融分析员、投资银行家、财务计划人、企业并购专家等；各类发明家、建筑师、社论作家、设计师、艺术家等");
                return output;
            }
            else if (result.Equals("ISTP"))
            {
                output.Add(
                       "1.冷静旁观者—安静、预留余地、弹性及会以无偏见的好奇心与未预期原始的幽默观察与分析。<br />" +
                       "                2.有兴趣于探索原因及效果，技术事件是为何及如何运作且使用逻辑的原理组构事实、重视效能。<br />" +
                       "                3.擅长于掌握问题核心及找出解决方式。<br />" +
                       "                4.分析成事的缘由且能实时由大量资料中找出实际问题的核心。");
                output.Add("技术领域、证券、金融业贸易、商业领域、户外、运动、艺术等领域");
                output.Add("机械、电气、电子工程师、各类技术专家和技师、计算机硬件、系统集成专业人员等；证券分析师、金融、财务顾问、经济学研究者等；贸易商、商品经销商、产品代理商（有形产品为主）等； 警察、侦探、体育工作者、赛车手、飞行员、雕塑家、手工制作、画家等");
                return output;
            }
            else if (result.Equals("ISFP"))
            {
                output.Add(
                       "1.羞怯的、安宁和善地、敏感的、亲切的、且行事谦虚。<br />" +
                       "                2.喜于避开争论，不对他人强加已见或价值观。<br />" +
                       "                3.无意于领导却常是忠诚的追随者。<br />" +
                       "                4.办事不急躁，安于现状无意于以过度的急切或努力破坏现况，且非成果导向。<br />" +
                       "                5.喜欢有自有的空间及照自订的时程办事。");
                output.Add("手工艺、艺术领域医护领域 商业、服务业领域");
                output.Add("时装、首饰设计师、装潢、园艺设计师、陶器、乐器、卡通、漫画制作者、素描画家、舞蹈演员、画家等；出诊医生、出诊护士、理疗师、牙科医生、个人健康和运动教练等；餐饮业、娱乐业业主、旅行社销售人员、体育用品、个人理疗用品销售员等");
                return output;
            }
            else if (result.Equals("INFP"))
            {
                output.Add(
                       "1.安静观察者，具理想性与对其价值观及重要之人具忠诚心。<br />" +
                       "                2.希外在生活形态与内在价值观相吻合。<br />" +
                       "                3.具好奇心且很快能看出机会所在。常担负开发创意的触媒者。<br />" +
                       "                4.除非价值观受侵犯，行事会具弹性、适应力高且承受力强。<br />" +
                       "                5.具想了解及发展他人潜能的企图。想作太多且作事全神贯注。<br />" +
                       "                6.对所处境遇及拥有不太在意。<br />" +
                       "                7.具适应力、有弹性除非价值观受到威胁。");
                output.Add("创作性、艺术类教育、研究、咨询类");
                output.Add("各类艺术家、插图画家、诗人、小说家、建筑师、设计师、文学编辑、艺术指导、记者等；大学老师（人文类）、心理学工作者、心理辅导和咨询人员、社科类研究人员、社会工作者、教育顾问、图书管理者、翻译家等");
                return output;
            }
            else if (result.Equals("INTP"))
            {
                output.Add(
                       "1.安静、自持、弹性及具适应力。<br />" +
                       "                2.特别喜爱追求理论与科学事理。<br />" +
                       "                3.习于以逻辑及分析来解决问题—问题解决者。<br />" +
                       "                4.最有兴趣于创意事务及特定工作，对聚会与闲聊无　大兴趣。<br />" +
                       "                5.追求可发挥个人强烈兴趣的生涯。<br />" +
                       "                6.追求发展对有兴趣事务之逻辑解释。");
                output.Add("计算机技术、理论研究、学术领域专业领域、创造性领域");
                output.Add("软件设计员、系统分析师、计算机程序员、数据库管理、故障排除专家等；大学教授、科研机构研究人员、数学家、物理学家、经济学家、考古学家、历史学家等；证券分析师、金融投资顾问、律师、法律顾问、财务专家、侦探等；各类发明家、作家、设计师、音乐家、艺术家、艺术鉴赏家等");
                return output;
            }
            else if (result.Equals("ESTP"))
            {
                output.Add(
                       "1.擅长现场实时解决问题—解决问题者。<br />" +
                       "                2.喜欢办事并乐于其中及过程。<br />" +
                       "                3.倾向于喜好技术事务及运动，交结同好友人。<br />" +
                       "                4.具适应性、容忍度、务实性；投注心力于会很快具　成效工作。<br />" +
                       "                5.不喜欢冗长概念的解释及理论。<br />" +
                       "                6.最专精于可操作、处理、分解或组合的真实事务。");
                output.Add("贸易、商业、某些特殊领域服务业 金融证券业 娱乐、体育、艺术领域");
                output.Add("各类贸易商、批发商、中间商、零售商、房地产经纪人、保险经济人、汽车销售人员、私家侦探、警察等。餐饮、娱乐及其他各类服务业的业主、主管、特许经营者、自由职业者等。股票经纪人、证券分析师、理财顾问、个人投资者等。娱乐节目主持人、体育节目评论、脱口秀、音乐、舞蹈表演者、健身教练、体育工作者等");
                return output;
            }
            else if (result.Equals("ESFP"))
            {
                output.Add(
                       "1.外向、和善、接受性、乐于分享喜乐予他人。<br />" +
                       "                2.喜欢与他人一起行动且促成事件发生，在学习时亦然。<br />" +
                       "                3.知晓事件未来的发展并会热列参与。<br />" +
                       "                4.最擅长于人际相处能力及具备完备常识，很有弹性能立即　适应他人与环境。<br />" +
                       "                5.对生命、人、物质享受的热爱者。");
                output.Add("消费类商业、服务业领域广告业、娱乐业领域、旅游业、社区服务等其他领域");
                output.Add("精品店、商场销售人员、娱乐、餐饮业客户经理、房地产销售人员、汽车销售人员、市场营销人员（消费类产品）等；广告企业中的设计师、创意人员、客户经理、时装设计和表演人员、摄影师、节目主持人、脱口秀演员等；旅游企业中的销售、服务人员、导游、社区工作人员、自愿工作者、公共关系专家、健身和运动教练、医护人员等");
                return output;
            }
            else if (result.Equals("ENFP"))
            {
                output.Add(
                       "1.充满热忱、活力充沛、聪明的、富想象力的，视生命充满机会但期能得自他人肯定与支持。<br />" +
                       "                2.几乎能达成所有有兴趣的事。<br />" +
                       "                3.对难题很快就有对策并能对有困难的人施予援手。<br />" +
                       "                4.依赖能改善的能力而无须预作规划准备。<br />" +
                       "                5.为达目的常能找出强制自己为之的理由。<br />" +
                       "                6.即兴执行者。");
                output.Add("广告创意、广告撰稿人，市场营销和宣传策划、市场调研人员、艺术指导、公关专家、公司对外发言人等");
                output.Add("儿童教育老师、大学老师（人文类）、心理学工作者、心理辅导和咨询人员、职业规划顾问、社会工作者、人力资源专家、培训师、演讲家等；记者（访谈类）、节目策划和主持人、专栏作家、剧作家、艺术指导、设计师、卡通制作者、电影、电视制片人等");
                return output;
            }
            else if (result.Equals("ENTP"))
            {
                output.Add(
                       "1.反应快、聪明、长于多样事务。<br />" +
                       "                2.具激励伙伴、敏捷及直言讳专长。<br />" +
                       "                3.会为了有趣对问题的两面加予争辩。<br />" +
                       "                4.对解决新及挑战性的问题富有策略，但会轻忽或厌烦经常的任务与细节。<br />" +
                       "                5.兴趣多元，易倾向于转移至新生的兴趣。<br />" +
                       "                6.对所想要的会有技巧地找出逻辑的理由。<br />" +
                       "                7.长于看清础他人，有智能去解决新或有挑战的问题。");
                output.Add("投资顾问、项目策划、投资银行、自我创业市场营销、创造性领域、公共关系、政治");
                output.Add("投资顾问（房地产、金融、贸易、商业等）、各类项目的策划人和发起者、投资银行家、风险投资人、企业业主（新兴产业）等市场营销人员、各类产品销售经理、广告创意、艺术总监、访谈类节目主持人、制片人等公共关系专家、公司对外发言人、社团负责人、政治家等");
                return output;
            }
            else if (result.Equals("ESTJ"))
            {
                output.Add(
                       "1.务实、真实、事实倾向，具企业或技术天份。<br />" +
                       "                2.不喜欢抽象理论；最喜欢学习可立即运用事理。<br />" +
                       "                3.喜好组织与管理活动且专注以最有效率方式行事以达致成效。<br />" +
                       "                4.具决断力、关注细节且很快作出决策—优秀行政者。<br />" +
                       "                5.会忽略他人感受。<br />" +
                       "                6.喜作领导者或企业主管。");
                output.Add("无明显领域特征");
                output.Add("大、中型外资企业员工、业务经理、中层经理（多分布在财务、营运、物流采购、销售管理、项目管理、工厂管理、人事行政部门）、职业经理人、各类中小型企业主管和业主");
                return output;
            }
            else if (result.Equals("ESFJ"))
            {
                output.Add(
                       "1.诚挚、爱说话、合作性高、受　欢迎、光明正大 的—天生的　合作者及活跃的组织成员。<br />" +
                       "                2.重和谐且长于创造和谐。<br />" +
                       "                3.常作对他人有益事务。<br />" +
                       "                4.给予鼓励及称许会有更佳工作成效。<br />" +
                       "                5.最有兴趣于会直接及有形影响人们生活的事务。<br />" +
                       "                6.喜欢与他人共事去精确且准时地完成工作。");
                output.Add("无明显领域特征");
                output.Add("办公室行政或管理人员、秘书、总经理助理、项目经理、客户服务部人员、采购和物流管理人员等；内科医生及其它各类医生、牙科医生、护士、健康护理指导师、饮食学、营养学专家、小学教师（班主任）、学校管理者等；银行、酒店、大型企业客户服务代表、客户经理、公共关系部主任、商场经理、餐饮业业主和管理人员等");
                return output;
            }
            else if (result.Equals("ENFJ"))
            {
                output.Add(
                       "1.热忱、易感应及负责任的--具能鼓励他人的领导风格。<br />" +
                       "                2.对别人所想或希求会表达真正关切且切实用心去处理。<br />" +
                       "                3.能怡然且技巧性地带领团体讨论或演示文稿提案。<br />" +
                       "                4.爱交际、受欢迎及富同情心。<br />" +
                       "                5.对称许及批评很在意。<br />" +
                       "                6.喜欢带引别人且能使别人或团体发挥潜能。");
                output.Add("培训、咨询、教育新闻传播、公共关系、文化艺术");
                output.Add("人力资源培训主任、销售、沟通、团队培训员、职业指导顾问、心理咨询工作者、大学教师（人文学科类）、教育学、心理学研究人员等；记者、撰稿人、节目主持人（新闻、采访类）、公共关系专家、社会活动家、文艺工作者、平面设计师、画家、音乐家等");
                return output;
            }
            else if (result.Equals("ENTJ"))
            {
                output.Add(
                       "1.坦诚、具决策力的活动领导者。<br />" +
                       "                2.长于发展与实施广泛的系统以解决组织的问题。<br />" +
                       "                3.专精于具内涵与智能的谈话如对公众演讲。<br />" +
                       "                4.乐于经常吸收新知且能广开信息管道。<br />" +
                       "                5.易生过度自信，会强于表达自已创见。<br />" +
                       "                6.喜于长程策划及目标设定。");
                output.Add("工商业、政界、金融和投资领域管理咨询、培训、专业性领域");
                output.Add("各类企业的高级主管、总经理、企业主、社会团体负责人、政治家等；投资银行家、风险投资家、股票经纪人、公司财务经理、财务顾问、经济学家企业管理顾问、企业战略顾问、项目顾问、专项培训师等；律师、法官、知识产权专家、大学教师、科技专家等");
                return output;
            }
            return null;
        }

        public void calculate(List<Answer> alist)
        {
            if (alist[0].getAnswer() == 0) { J++; }
            else if (alist[0].getAnswer() == 1) { P++; }

            if (alist[1].getAnswer() == 0) { P++; }
            else if (alist[1].getAnswer() == 1) { J++; }

            if (alist[2].getAnswer() == 0) { S++; }
            else if (alist[2].getAnswer() == 1) { N++; }

            if (alist[3].getAnswer() == 0) { E++; }
            else if (alist[3].getAnswer() == 1) { I++; }

            if (alist[4].getAnswer() == 0) { N++; }
            else if (alist[4].getAnswer() == 1) { S++; }

            if (alist[5].getAnswer() == 0) { F++; }
            else if (alist[5].getAnswer() == 1) { T++; }

            if (alist[6].getAnswer() == 0) { P++; }
            else if (alist[6].getAnswer() == 1) { J++; }

            if (alist[7].getAnswer() == 0) { E++; }
            else if (alist[7].getAnswer() == 1) { I++; }

            if (alist[8].getAnswer() == 0) { J++; }
            else if (alist[8].getAnswer() == 1) { P++; }

            if (alist[9].getAnswer() == 0) { P++; }
            else if (alist[9].getAnswer() == 1) { J++; }

            if (alist[10].getAnswer() == 0) { J++; }
            else if (alist[10].getAnswer() == 1) { P++; }

            if (alist[11].getAnswer() == 0) { I++; }
            else if (alist[11].getAnswer() == 1) { E++; }

            if (alist[12].getAnswer() == 0) { S++; }
            else if (alist[12].getAnswer() == 1) { N++; }

            if (alist[13].getAnswer() == 0) { E++; }
            else if (alist[13].getAnswer() == 1) { I++; }

            if (alist[14].getAnswer() == 0) { N++; }
            else if (alist[14].getAnswer() == 1) { S++; }

            if (alist[15].getAnswer() == 0) { F++; }
            else if (alist[15].getAnswer() == 1) { T++; }

            if (alist[16].getAnswer() == 0) { P++; }
            else if (alist[16].getAnswer() == 1) { J++; }

            if (alist[17].getAnswer() == 0) { I++; }
            else if (alist[17].getAnswer() == 1) { E++; }

            if (alist[18].getAnswer() == 0) { E++; }
            else if (alist[18].getAnswer() == 1) { I++; }

            if (alist[19].getAnswer() == 0) { J++; }
            else if (alist[19].getAnswer() == 1) { P++; }

            if (alist[20].getAnswer() == 0) { P++; }
            else if (alist[20].getAnswer() == 1) { J++; }

            if (alist[21].getAnswer() == 0) { I++; }
            else if (alist[21].getAnswer() == 1) { E++; }

            if (alist[22].getAnswer() == 0) { E++; }
            else if (alist[22].getAnswer() == 1) { I++; }

            if (alist[23].getAnswer() == 0) { N++; }
            else if (alist[23].getAnswer() == 1) { S++; }

            if (alist[24].getAnswer() == 0) { P++; }
            else if (alist[24].getAnswer() == 1) { J++; }

            if (alist[25].getAnswer() == 0) { I++; }
            else if (alist[25].getAnswer() == 1) { E++; }

            if (alist[26].getAnswer() == 0) { I++; }
            else if (alist[26].getAnswer() == 1) { E++; }

            if (alist[27].getAnswer() == 0) { J++; }
            else if (alist[27].getAnswer() == 1) { P++; }

            if (alist[28].getAnswer() == 0) { N++; }
            else if (alist[28].getAnswer() == 1) { S++; }

            if (alist[29].getAnswer() == 0) { F++; }
            else if (alist[29].getAnswer() == 1) { T++; }

            if (alist[30].getAnswer() == 0) { T++; }
            else if (alist[30].getAnswer() == 1) { F++; }

            if (alist[31].getAnswer() == 0) { S++; }
            else if (alist[31].getAnswer() == 1) { N++; }

            if (alist[32].getAnswer() == 0) { P++; }
            else if (alist[32].getAnswer() == 1) { J++; }

            if (alist[33].getAnswer() == 0) { E++; }
            else if (alist[33].getAnswer() == 1) { I++; }

            if (alist[34].getAnswer() == 0) { I++; }
            else if (alist[34].getAnswer() == 1) { E++; }

            if (alist[35].getAnswer() == 0) { J++; }
            else if (alist[35].getAnswer() == 1) { P++; }

            if (alist[36].getAnswer() == 0) { N++; }
            else if (alist[36].getAnswer() == 1) { S++; }

            if (alist[37].getAnswer() == 0) { F++; }
            else if (alist[37].getAnswer() == 1) { T++; }

            if (alist[38].getAnswer() == 0) { T++; }
            else if (alist[38].getAnswer() == 1) { F++; }

            if (alist[39].getAnswer() == 0) { S++; }
            else if (alist[39].getAnswer() == 1) { N++; }

            if (alist[40].getAnswer() == 0) { P++; }
            else if (alist[40].getAnswer() == 1) { J++; }

            if (alist[41].getAnswer() == 0) { I++; }
            else if (alist[41].getAnswer() == 1) { E++; }

            if (alist[42].getAnswer() == 0) { J++; }
            else if (alist[42].getAnswer() == 1) { P++; }

            if (alist[43].getAnswer() == 0) { N++; }
            else if (alist[43].getAnswer() == 1) { S++; }

            if (alist[44].getAnswer() == 0) { F++; }
            else if (alist[44].getAnswer() == 1) { T++; }

            if (alist[45].getAnswer() == 0) { T++; }
            else if (alist[45].getAnswer() == 1) { F++; }

            if (alist[46].getAnswer() == 0) { S++; }
            else if (alist[46].getAnswer() == 1) { N++; }

            if (alist[47].getAnswer() == 0) { I++; }
            else if (alist[47].getAnswer() == 1) { E++; }

            if (alist[48].getAnswer() == 0) { J++; }
            else if (alist[48].getAnswer() == 1) { P++; }

            if (alist[49].getAnswer() == 0) { N++; }
            else if (alist[49].getAnswer() == 1) { S++; }

            if (alist[50].getAnswer() == 0) { J++; }
            else if (alist[50].getAnswer() == 1) { P++; }

            if (alist[51].getAnswer() == 0) { F++; }
            else if (alist[51].getAnswer() == 1) { T++; }

            if (alist[52].getAnswer() == 0) { T++; }
            else if (alist[52].getAnswer() == 1) { F++; }

            if (alist[53].getAnswer() == 0) { I++; }
            else if (alist[53].getAnswer() == 1) { E++; }

            if (alist[54].getAnswer() == 0) { N++; }
            else if (alist[54].getAnswer() == 1) { S++; }

            if (alist[55].getAnswer() == 0) { F++; }
            else if (alist[55].getAnswer() == 1) { T++; }

            if (alist[56].getAnswer() == 0) { T++; }
            else if (alist[56].getAnswer() == 1) { F++; }

            if (alist[57].getAnswer() == 0) { S++; }
            else if (alist[57].getAnswer() == 1) { N++; }

            if (alist[58].getAnswer() == 0) { J++; }
            else if (alist[58].getAnswer() == 1) { P++; }

            if (alist[59].getAnswer() == 0) { I++; }
            else if (alist[59].getAnswer() == 1) { E++; }

            if (alist[60].getAnswer() == 0) { S++; }
            else if (alist[60].getAnswer() == 1) { N++; }

            if (alist[61].getAnswer() == 0) { E++; }
            else if (alist[61].getAnswer() == 1) { I++; }

            if (alist[62].getAnswer() == 0) { N++; }
            else if (alist[62].getAnswer() == 1) { S++; }

            if (alist[63].getAnswer() == 0) { F++; }
            else if (alist[63].getAnswer() == 1) { T++; }

            if (alist[64].getAnswer() == 0) { P++; }
            else if (alist[64].getAnswer() == 1) { J++; }

            if (alist[65].getAnswer() == 0) { I++; }
            else if (alist[65].getAnswer() == 1) { E++; }

            if (alist[66].getAnswer() == 0) { E++; }
            else if (alist[66].getAnswer() == 1) { I++; }

            if (alist[67].getAnswer() == 0) { J++; }
            else if (alist[67].getAnswer() == 1) { P++; }

            if (alist[68].getAnswer() == 0) { T++; }
            else if (alist[68].getAnswer() == 1) { F++; }

            if (alist[69].getAnswer() == 0) { J++; }
            else if (alist[69].getAnswer() == 1) { P++; }

            if (alist[70].getAnswer() == 0) { P++; }
            else if (alist[70].getAnswer() == 1) { J++; }

            if (alist[71].getAnswer() == 0) { I++; }
            else if (alist[71].getAnswer() == 1) { E++; }

            if (alist[72].getAnswer() == 0) { S++; }
            else if (alist[72].getAnswer() == 1) { N++; }

            if (alist[73].getAnswer() == 0) { N++; }
            else if (alist[73].getAnswer() == 1) { S++; }

            if (alist[74].getAnswer() == 0) { T++; }
            else if (alist[74].getAnswer() == 1) { N++; }

            if (alist[75].getAnswer() == 0) { P++; }
            else if (alist[75].getAnswer() == 1) { J++; }

            if (alist[76].getAnswer() == 0) { E++; }
            else if (alist[76].getAnswer() == 1) { I++; }

            if (alist[77].getAnswer() == 0) { T++; }
            else if (alist[77].getAnswer() == 1) { F++; }

            if (alist[78].getAnswer() == 0) { N++; }
            else if (alist[78].getAnswer() == 1) { S++; }

            if (alist[79].getAnswer() == 0) { F++; }
            else if (alist[79].getAnswer() == 1) { T++; }

            if (alist[80].getAnswer() == 0) { T++; }
            else if (alist[80].getAnswer() == 1) { F++; }

            if (alist[81].getAnswer() == 0) { S++; }
            else if (alist[81].getAnswer() == 1) { N++; }

            if (alist[82].getAnswer() == 0) { N++; }
            else if (alist[82].getAnswer() == 1) { S++; }

            if (alist[83].getAnswer() == 0) { F++; }
            else if (alist[83].getAnswer() == 1) { T++; }

            if (alist[84].getAnswer() == 0) { T++; }
            else if (alist[84].getAnswer() == 1) { F++; }

            if (alist[85].getAnswer() == 0) { S++; }
            else if (alist[85].getAnswer() == 1) { N++; }

            if (alist[86].getAnswer() == 0) { N++; }
            else if (alist[86].getAnswer() == 1) { S++; }

            if (alist[87].getAnswer() == 0) { F++; }
            else if (alist[87].getAnswer() == 1) { T++; }

            if (alist[88].getAnswer() == 0) { T++; }
            else if (alist[88].getAnswer() == 1) { F++; }

            if (alist[89].getAnswer() == 0) { S++; }
            else if (alist[89].getAnswer() == 1) { N++; }

            if (alist[90].getAnswer() == 0) { F++; }
            else if (alist[90].getAnswer() == 1) { T++; }

            if (alist[91].getAnswer() == 0) { T++; }
            else if (alist[91].getAnswer() == 1) { F++; }

            if (alist[92].getAnswer() == 0) { N++; }
            else if (alist[92].getAnswer() == 1) { T++; }
        }
    }
}
