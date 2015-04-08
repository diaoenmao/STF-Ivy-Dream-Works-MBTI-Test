using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stanford.Models
{
    public class AnswerProcessor
    {
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
                       "2.行事务实、有序、实际 、 逻辑、真实及可信赖。<br />" +
                       "3.十分留意且乐于任何事（工作、居家、生活均有良好组织及有序。<br />" +
                       "4.负责任。<br />" +
                       "5.照设定成效来作出决策且不畏阻挠与闲言会坚定为之。<br />" +
                       "6.重视传统与忠诚。<br />" +
                       "7.传统性的思考者或经理。");
                return output;
            }
            else if (result.Equals("ISFJ"))
            {
                output.Add(
                       "1.安静、和善、负责任且有良心。<br />" +
                       "2.行事尽责投入。<br />" +
                       "3.安定性高，常居项目工作或团体之安定力量。<br />" +
                       "4.愿投入、吃苦及力求精确。<br />" +
                       "5.兴趣通常不在于科技方面。对细节事务有耐心。<br />" +
                       "6.忠诚、考虑周到、知性且会关切他人感受。<br />" +
                       "7.致力于创构有序及和谐的工作与家庭环境。");
                return output;
            }
            else if (result.Equals("INFJ"))
            {
                output.Add(
                       "1.因为坚忍、创意及必须达成的意图而能成功。<br />" +
                       "2.会在工作中投注最大的努力。<br />" +
                       "3.默默强力的、诚挚的及用心的关切他人。<br />" +
                       "4.因坚守原则而受敬重。<br />" +
                       "5.提出造福大众利益的明确远景而为人所尊敬与追随。<br />" +
                       "6.追求创见、关系及物质财物的意义及关联。<br />" +
                       "7.想了解什么能激励别人及对他人具洞察力。<br /> " +
                       "8.光明正大且坚信其价值观。<br />" +
                       "9.有组织且果断地履行其愿景。");
                return output;
            }
            else if (result.Equals("INTJ"))
            {
                output.Add(
                      "1.具强大动力与本意来达成目的与创意—固执顽固者。<br />" +
                      "2.有宏大的愿景且能快速在众多外界事件中找出有意义的模范。<br />" +
                      "3.对所承负职务，具良好能力于策划工作并完成。<br />" +
                      "4.具怀疑心、挑剔性、独立性、果决，对专业水准及绩效要求高。");
                return output;
            }
            else if (result.Equals("ISTP"))
            {
                output.Add(
                       "1.冷静旁观者—安静、预留余地、弹性及会以无偏见的好奇心与未预期原始的幽默观察与分析。<br />" +
                       "2.有兴趣于探索原因及效果，技术事件是为何及如何运作且使用逻辑的原理组构事实、重视效能。<br />" +
                       "3.擅长于掌握问题核心及找出解决方式。<br />" +
                       "4.分析成事的缘由且能实时由大量资料中找出实际问题的核心。");
                return output;
            }
            else if (result.Equals("ISFP"))
            {
                output.Add(
                       "1.羞怯的、安宁和善地、敏感的、亲切的、且行事谦虚。<br />" +
                       "2.喜于避开争论，不对他人强加已见或价值观。<br />" +
                       "3.无意于领导却常是忠诚的追随者。<br />" +
                       "4.办事不急躁，安于现状无意于以过度的急切或努力破坏现况，且非成果导向。<br />" +
                       "5.喜欢有自有的空间及照自订的时程办事。");
                return output;
            }
            else if (result.Equals("INFP"))
            {
                output.Add(
                       "1.安静观察者，具理想性与对其价值观及重要之人具忠诚心。<br />" +
                       "2.希外在生活形态与内在价值观相吻合。<br />" +
                       "3.具好奇心且很快能看出机会所在。常担负开发创意的触媒者。<br />" +
                       "4.除非价值观受侵犯，行事会具弹性、适应力高且承受力强。<br />" +
                       "5.具想了解及发展他人潜能的企图。想作太多且作事全神贯注。<br />" +
                       "6.对所处境遇及拥有不太在意。<br />" +
                       "7.具适应力、有弹性除非价值观受到威胁。");
                return output;
            }
            else if (result.Equals("INTP"))
            {
                output.Add(
                       "1.安静、自持、弹性及具适应力。<br />" +
                       "2.特别喜爱追求理论与科学事理。<br />" +
                       "3.习于以逻辑及分析来解决问题—问题解决者。<br />" +
                       "4.最有兴趣于创意事务及特定工作，对聚会与闲聊无　大兴趣。<br />" +
                       "5.追求可发挥个人强烈兴趣的生涯。<br />" +
                       "6.追求发展对有兴趣事务之逻辑解释。");
                return output;
            }
            else if (result.Equals("ESTP"))
            {
                output.Add(
                       "1.擅长现场实时解决问题—解决问题者。<br />" +
                       "2.喜欢办事并乐于其中及过程。<br />" +
                       "3.倾向于喜好技术事务及运动，交结同好友人。<br />" +
                       "4.具适应性、容忍度、务实性；投注心力于会很快具　成效工作。<br />" +
                       "5.不喜欢冗长概念的解释及理论。<br />" +
                       "6.最专精于可操作、处理、分解或组合的真实事务。");
                return output;
            }
            else if (result.Equals("ESFP"))
            {
                output.Add(
                       "1.外向、和善、接受性、乐于分享喜乐予他人。<br />" +
                       "2.喜欢与他人一起行动且促成事件发生，在学习时亦然。<br />" +
                       "3.知晓事件未来的发展并会热列参与。<br />" +
                       "4.最擅长于人际相处能力及具备完备常识，很有弹性能立即　适应他人与环境。<br />" +
                       "5.对生命、人、物质享受的热爱者。");
                return output;
            }
            else if (result.Equals("ENFP"))
            {
                output.Add(
                       "1.充满热忱、活力充沛、聪明的、富想象力的，视生命充满机会但期能得自他人肯定与支持。<br />" +
                       "2.几乎能达成所有有兴趣的事。<br />" +
                       "3.对难题很快就有对策并能对有困难的人施予援手。<br />" +
                       "4.依赖能改善的能力而无须预作规划准备。<br />" +
                       "5.为达目的常能找出强制自己为之的理由。<br />" +
                       "6.即兴执行者。");
                return output;
            }
            else if (result.Equals("ENTP"))
            {
                output.Add(
                       "1.反应快、聪明、长于多样事务。<br />" +
                       "2.具激励伙伴、敏捷及直言讳专长。<br />" +
                       "3.会为了有趣对问题的两面加予争辩。<br />" +
                       "4.对解决新及挑战性的问题富有策略，但会轻忽或厌烦经常的任务与细节。<br />" +
                       "5.兴趣多元，易倾向于转移至新生的兴趣。<br />" +
                       "6.对所想要的会有技巧地找出逻辑的理由。<br />" +
                       "7.长于看清础他人，有智能去解决新或有挑战的问题。");
                return output;
            }
            else if (result.Equals("ESTJ"))
            {
                output.Add(
                       "1.务实、真实、事实倾向，具企业或技术天份。<br />" +
                       "2.不喜欢抽象理论；最喜欢学习可立即运用事理。<br />" +
                       "3.喜好组织与管理活动且专注以最有效率方式行事以达致成效。<br />" +
                       "4.具决断力、关注细节且很快作出决策—优秀行政者。<br />" +
                       "5.会忽略他人感受。<br />" +
                       "6.喜作领导者或企业主管。");
                return output;
            }
            else if (result.Equals("ESFJ"))
            {
                output.Add(
                       "1.诚挚、爱说话、合作性高、受　欢迎、光明正大 的—天生的　合作者及活跃的组织成员。<br />" +
                       "2.重和谐且长于创造和谐。<br />" +
                       "3.常作对他人有益事务。<br />" +
                       "4.给予鼓励及称许会有更佳工作成效。<br />" +
                       "5.最有兴趣于会直接及有形影响人们生活的事务。<br />" +
                       "6.喜欢与他人共事去精确且准时地完成工作。");
                return output;
            }
            else if (result.Equals("ENFJ"))
            {
                output.Add(
                       "1.热忱、易感应及负责任的--具能鼓励他人的领导风格。<br />" +
                       "2.对别人所想或希求会表达真正关切且切实用心去处理。<br />" +
                       "3.能怡然且技巧性地带领团体讨论或演示文稿提案。<br />" +
                       "4.爱交际、受欢迎及富同情心。<br />" +
                       "5.对称许及批评很在意。<br />" +
                       "6.喜欢带引别人且能使别人或团体发挥潜能。");
                return output;
            }
            else if (result.Equals("ENTJ"))
            {
                output.Add(
                       "1.坦诚、具决策力的活动领导者。<br />" +
                       "2.长于发展与实施广泛的系统以解决组织的问题。<br />" +
                       "3.专精于具内涵与智能的谈话如对公众演讲。<br />" +
                       "4.乐于经常吸收新知且能广开信息管道。<br />" +
                       "5.易生过度自信，会强于表达自已创见。<br />" +
                       "6.喜于长程策划及目标设定。");
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
