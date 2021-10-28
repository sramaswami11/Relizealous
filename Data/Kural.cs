using Relizealous.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Relizealous.Data.Adhikaram;

namespace Relizealous.Data
{
    public class Kural
    {
        public string Statement { get; set; }

        public string Description { get; set; }

        public string AudioLink { get; set; }

        public  AdhikaramName Adhikaram { get; set; }

    public static readonly Kural[] Collection
       = new Kural[]
       {
            new Kural //1
            {
                Statement="1.அகர முதல எழுத்தெல்லாம் ஆதி பகவன் முதற்றே உலகு",
                Description="எழுத்துக்கள் எல்லாம் அகரத்தை அடிப்படையாக கொண்டிருக்கின்றன. அதுபோல உலகம் கடவுளை அடிப்படையாக கொண்டிருக்கிறது.",
                AudioLink = "https://raw.githubusercontent.com/sramaswami11/Relizealous/master/sounds/duh.mp3",
                Adhikaram = AdhikaramName.கடவுள்_வாழ்த்து
            },
            new Kural //2
            {
               Statement="2.கற்றதனால் ஆய பயனென்கொல் வாலறிவன் நற்றாள் தொழாஅர் எனின்",
               Description="தூய அறிவு வடிவாக விளங்கும் இறைவனுடைய நல்ல திருவடிகளை தொழாமல் இருப்பாரானால், அவர் கற்ற கல்வியினால் ஆகிய பயன் என்ன?",
               AudioLink = "sounds/Katranathal Aya.m4a",
               Adhikaram = AdhikaramName.கடவுள்_வாழ்த்து
            },
             new Kural //3
            {
               Statement="3.மலர்மிசை ஏகினான் மாணடி சேர்ந்தார் நிலமிசை நீடுவாழ் வார்",
               Description="அன்பரின் அகமாகிய மலரில் வீற்றிருக்கும் கடவுளின் சிறந்த திருவடிகளை பொருந்தி நினைக்கின்றவர், இன்ப உலகில் நிலைத்து வாழ்வார்",
               AudioLink = "sounds/Malarmisai eginan.m4a",
               Adhikaram = AdhikaramName.கடவுள்_வாழ்த்து
            },
            new Kural //4
            {
               Statement="4.வேண்டுதல்வேண் டாமை இலானடி சேர்ந்தார்க்கு யாண்டும் இடும்பை இல",
                Description="விருப்பு வெறுப்பு இல்லாத கடவுளின் திருவடிகளை பொருந்தி நினைக்கின்றவர்க்கு எப்போதும் எவ்விடத்திலும் துன்பம் இல்லை",
                AudioLink = "sounds/Vendudhal vendamai.m4a",
                Adhikaram = AdhikaramName.கடவுள்_வாழ்த்து
            },
             new Kural //5
            {
               Statement="5.இருள்சேர் இருவினையும் சேரா இறைவன் பொருள்சேர் புகழ்புரிந்தார் மாட்டு",
                Description="கடவுளின் உண்மைப் புகழை விரும்பி அன்பு செலுத்துகின்றவரிடம் அறியாமையால் விளையும் இருவகை வினையும் சேர்வதில்லை",
                AudioLink = "sounds/duh.mp3",
                Adhikaram = AdhikaramName.கடவுள்_வாழ்த்து
             },
            new Kural //6
            {
               Statement="6.பொறிவாயில் ஐந்தவித்தான் பொய்தீர் ஒழுக்க நெறிநின்றார் நீடுவாழ் வார்",
                Description="ஐம்பொறி வாயிலாக பிறக்கும் வேட்கைகளை அவித்த இறைவனுடைய பொய்யற்ற ஒழுக்க நெறியில் நின்றவர், நிலை பெற்ற நல்வாழ்க்கை வாழ்வர்",
                AudioLink = "sounds/dwayne.mp3",
                Adhikaram = AdhikaramName.கடவுள்_வாழ்த்து
            },
            new Kural //7
            {
               Statement="7.தனக்குவமை இல்லாதான் தாள்சேர்ந்தார்க் கல்லால் மனக்கவலை மாற்றல் அரிது",
                Description="தனக்கு ஒப்புமை இல்லாத தலைவனுடைய திருவடிகளைப் பொருந்தி நினைக்கின்றவர் அல்லாமல், மற்றவர்க்கு மனக்கவலையை மாற்ற முடியாது",
                AudioLink = "sounds/dwayne.mp3",
                Adhikaram = AdhikaramName.கடவுள்_வாழ்த்து
            },
             new Kural //8
            {
               Statement="8.அறவாழி அந்தணன் தாள்சேர்ந்தார்க் கல்லால் பிறவாழி நீந்தல் அரிது",
                Description="அறக்கடலாக விளங்கும் கடவுளின் திருவடிகளைப் பொருந்தி நினைக்கின்றவர் அல்லாமல், மற்றவர் பொருளும் இன்பமுமாகிய மற்ற கடல்களைக் கடக்க முடியாது",
                AudioLink = "sounds/dwayne.mp3",
                Adhikaram = AdhikaramName.கடவுள்_வாழ்த்து
            },
              new Kural //9
            {
               Statement="9.கோளில் பொறியின் குணமிலவே எண்குணத்தான் தாளை வணங்காத் தலை",
                Description="கேட்காதசெவி, பார்க்காத கண் போன்ற எண் குணங்களை உடைய கடவுளின் திருவடிகளை வணங்காதவரின் தலைகள் பயனற்றவைகளாம்",
                AudioLink = "sounds/dwayne.mp3",
                Adhikaram = AdhikaramName.கடவுள்_வாழ்த்து
            },
             new Kural //10
            {
               Statement="10.பிறவிப் பெருங்கடல் நீந்துவர் நீந்தார் இறைவன் அடிசேரா தார்",
                Description="இறைவனுடைய திருவடிகளை பொருந்தி நினைக்கின்றவர் பிறவியாகிய பெரிய கடலைக் கடக்க முடியும். மற்றவர் கடக்க முடியாது",
                AudioLink = "sounds/dwayne.mp3",
                Adhikaram = AdhikaramName.கடவுள்_வாழ்த்து
            },
             new Kural //11
            {
               Statement="11.வான்நின்று உலகம் வழங்கி வருதலால் தான்அமிழ்தம் என்றுணரற் பாற்று.",
               Description="மழை பெய்ய உலகம் வாழ்ந்து வருவதால், மழையானது உலகத்து வாழும் உயிர்களுக்கு அமிழ்தம் என்று உணரத்தக்கதாகும்.",
               AudioLink = "sounds/dwayne.mp3",
               Adhikaram = AdhikaramName.வான்சிறப்பு
            },
            new Kural //12
            {
               Statement="12.துப்பார்க்குத் துப்பாய துப்பாக்கித் துப்பார்க்குத் துப்பாய தூஉம் மழை.",
               Description="உண்பவர்க்குத் தக்க உணவுப் பொருள்களை விளைவித்துத் தருவதோடு, பருகுவோர்க்குத் தானும் ஓர் உணவாக இருப்பது மழையாகும்.",
               AudioLink = "sounds/dwayne.mp3",
               Adhikaram = AdhikaramName.வான்சிறப்பு
            },
              new Kural //13
            {
               Statement="13.விண்இன்று பொய்ப்பின் விரிநீர் வியனுலகத்து உள்நின்று உடற்றும் பசி.",
               Description="மழை பெய்யாமல் பொய்படுமானால், கடல் சூழ்ந்த அகன்ற உலகமாக இருந்தும் பசி உள்ளே நிலைத்து நின்று உயிர்களை வருத்தும்.",
               AudioLink = "sounds/dwayne.mp3",
               Adhikaram = AdhikaramName.வான்சிறப்பு
            },
            new Kural //14
            {
               Statement="14.ஏரின் உழாஅர் உழவர் புயல்என்னும் வாரி வளங்குன்றிக் கால்.",
               Description="மழை என்னும் வருவாய் வளம் குன்றி விட்டால், ( உணவுப் பொருள்களை உண்டாக்கும்) உழவரும் ஏர் கொண்டு உழமாட்டார்.",
               AudioLink = "sounds/dwayne.mp3",
               Adhikaram = AdhikaramName.வான்சிறப்பு
            },
              new Kural //15
            {
               Statement="15.கெடுப்பதூஉம் கெட்டார்க்குச் சார்வாய்மற் றாங்கே எடுப்பதூஉம் எல்லாம் மழை.",
               Description="பெய்யாமல் வாழ்வைக் கெடுக்க வல்லதும் மழை; மழையில்லாமல் வளம் கெட்டு நொந்தவர்க்கும் துணையாய் அவ்வாறே காக்க வல்லதும் மழையாகும்.",
               AudioLink = "sounds/dwayne.mp3",
               Adhikaram = AdhikaramName.வான்சிறப்பு
            },
            new Kural //16
            {
               Statement="16.விசும்பின் துளிவீழின் அல்லால்மற் றாங்கே பசும்புல் தலைகாண்பு அரிது.",
               Description="வானத்திலிருந்து மழைத்துளி வீழ்ந்தால் அல்லாமல், உலகத்தில் ஓரறிவுயிராகிய பசும்புல்லின் தலையையும் காண முடியாது.",
               AudioLink = "sounds/dwayne.mp3",
               Adhikaram = AdhikaramName.வான்சிறப்பு
            },
              new Kural //17
            {
               Statement="17.நெடுங்கடலும் தன்நீர்மை குன்றும் தடிந்தெழிலி தான்நல்கா தாகி விடின்.",
               Description="மேகம் கடலிலிருந்து நீரைக் கொண்டு அதனிடத்திலேயே பெய்யாமல் விடுமானால், பெரிய கடலும் தன் வளம் குன்றிப் போகும்.",
               AudioLink = "sounds/dwayne.mp3",
               Adhikaram = AdhikaramName.வான்சிறப்பு
            },
            new Kural //18
            {
               Statement="18.சிறப்பொடு பூசனை செல்லாது வானம் வறக்குமேல் வானோர்க்கும் ஈண்டு..",
               Description="மழை பெய்யாமல் போகுமானால் இவ்வுலகத்தில் வானோர்க்காக நடைபெறும் திருவிழாவும் நடைபெறாது; நாள் வழிபாடும் நடைபெறாது.",
               AudioLink = "sounds/dwayne.mp3",
               Adhikaram = AdhikaramName.வான்சிறப்பு
            },
              new Kural //19
            {
               Statement="19.தானம் தவம்இரண்டும் தங்கா வியன்உலகம் வானம் வழங்கா தெனின்.",
               Description="மழை பெய்யவில்லையானால், இந்த பெரிய உலகத்தில் பிறர் பொருட்டு செய்யும் தானமும், தம் பொருட்டு செய்யும் தவமும் இல்லையாகும்.",
               AudioLink = "sounds/dwayne.mp3",
               Adhikaram = AdhikaramName.வான்சிறப்பு
            },
            new Kural //20
            {
               Statement="20.நீர்இன்று அமையாது உலகெனின் யார்யார்க்கும் வான்இன்று அமையாது ஒழுக்கு.",
               Description="எப்படிப்பட்டவர்க்கும் நீர் இல்லாமல் உலக வாழ்க்கை நடைபெறாது என்றால், மழை இல்லையானால் ஒழுக்கமும் நிலைபெறாமல் போகும்.",
               AudioLink = "sounds/dwayne.mp3",
               Adhikaram = AdhikaramName.வான்சிறப்பு
            }
       };
    }
}
