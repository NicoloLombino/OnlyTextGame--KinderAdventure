using System;

namespace OnlyText_Adventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuto!");
            Console.WriteLine("Scrivi 'start' per cominciare");
            string startGame = Console.ReadLine();

            if (startGame == "start")               // CAPITOLO 1
            {
                Console.WriteLine("                                          ");
                Console.WriteLine("Ti trovi in un mondo post apocalittico");
                Console.WriteLine("Tutti i tuoi amici e parenti sono morti");
                Console.WriteLine("Hai perso molti dei tuoi ricordi");
                Console.WriteLine("L'unica cosa che ti tiene in vita è la speranza di trovare dei kinder da mangiare");
                Console.WriteLine("                                       ");
                Console.WriteLine("                                       ");
                Console.WriteLine("Ti svegli stanco, già sai che sarà un'altra brutta giornata");
                Console.WriteLine("Cosa fai?");
                Console.WriteLine("1. Cominci la tua ricerca giornaliera per trovare dei kinder");
                Console.WriteLine("2. Dormi altri 5 minuti, sicuramente ti sveglierai con più energie");
                Console.WriteLine("                  ");
                string WakeUp = Console.ReadLine();

                if (WakeUp == "1")   // TI ALZI O DORMI??   TI ALZI
                {
                    Console.WriteLine("                             ");
                    Console.WriteLine("Cammini e la strada sembra tranquilla e sicura");
                    Console.WriteLine("C'è caldo e ti rendi conto che hai dimenticato l'acqua a casa e hai molta sete");
                    Console.WriteLine("Vedi un piccola casa non molto lontano da te, sembra abbandonata");
                    Console.WriteLine("Cosa fai?");
                    Console.WriteLine("1. Esplori la casa, magari oltre all'acqua troverai dei kinder");
                    Console.WriteLine("2. Continui a camminare per la tua strada, la casa non sembra sicura");
                    Console.WriteLine("                              ");
                    string ToHouse = Console.ReadLine();

                    if (ToHouse == "1")   // EPLORI LA CASA
                    {
                        Console.WriteLine("                              ");
                        Console.WriteLine("Entri in casa, nessuna traccia di kinder o di acqua ma trovi una pistola ancora carica");
                        Console.WriteLine("Decidi di prenderla, la sicurezza non è mai abbastanza");
                        Console.WriteLine("Continui per la tua strada e trovi un vecchio mendicante, noti che tiene una bottiglia d'acqua con mano destra e un piccolo zaino sulla spalla");
                        Console.WriteLine("Cosa fai?");
                        Console.WriteLine("1. Spari al vecchio e rubi tutti i suoi averi");
                        Console.WriteLine("2. Sei pacifico e non vuoi fare del male a nessuno, vai a chiedere aiuto gentilmente");
                        Console.WriteLine("3. Sei pacifico ma non ti fidi di nessuno, continui per la tua strada");
                        Console.WriteLine("                                  ");
                        string OldMan = Console.ReadLine();

                        if (OldMan == "1")
                        {
                            Console.WriteLine("                                  ");
                            Console.WriteLine("Sei un assassino ma almeno anche oggi potrai sopravvivere");
                            Console.WriteLine("Trovi acqua e altre cose inutili che lascerai sul cadavere del vecchio");
                            Console.WriteLine("Continuando per la tua strada trovi un'altra casa, questa sembra abitata");
                            ToSecondHouse();
                        }

                        if (OldMan == "2")
                        {
                            Console.WriteLine("                                  ");
                            Console.WriteLine("Ti avvicini al vecchio con tranquillità e provi a salutarlo");
                            Console.WriteLine("Il vecchio si spaventa, sembri un ladro");
                            Console.WriteLine("Cerchi di farlo ragionare ma sembra non parla la tua lingua");
                            Console.WriteLine("Il vecchio è un esperto di kick boxing e con un calcio ti rompe l'osso del collo");
                            Console.WriteLine("SEI MORTO");
                            Console.WriteLine("                                  ");
                        }

                        if (OldMan == "3")
                        {
                            Console.WriteLine("                                  ");
                            Console.WriteLine("Fai finta di niente e continui a camminare, meglio non parlare con gli sconosciuti");
                            Console.WriteLine("Fortunatamente trovi un piccolo lago con acqua abbastanza pulita, riempi la tua borraccia");
                            Console.WriteLine("Puoi sopravvivere un altro giorno");
                            Console.WriteLine("Continuando per la tua strada trovi un'altra casa, questa sembra abitata");
                            ToSecondHouse();
                        }



                    }

                    if (ToHouse == "2")   // NON EPLORI LA CASA
                    {
                        Console.WriteLine("                          ");
                        Console.WriteLine("Decidi di continuare la tua strada ma ti senti sempre più stanco");
                        Console.WriteLine("Camminando ti rendi conto che non troverai più niente");
                        Console.WriteLine("Cerchi di tornare indietro ma lentamente perdi conoscenza per la stanchezza");
                        Console.WriteLine("SEI MORTO");
                        Console.WriteLine("                                  ");

                    }
                }

                if (WakeUp == "2")      // TI ALZI O DORMI??   DORMI
                {
                    Console.WriteLine("Ti svegli e hai dormito più del previsto, è stata una pessima idea");
                    Console.WriteLine("Trovi 3 uomini, ti minacciano con una pistola e chiedono tutti i tuoi soldi");
                    Console.WriteLine("Cosa fai?");
                    Console.WriteLine("1. Provi a difenderti");
                    Console.WriteLine("2. Consegni tutti i tuoi averi sperando che non ti facciano del male");
                    Console.WriteLine("                                            ");
                    string FightorNot = Console.ReadLine();

                    if (FightorNot == "1")
                    {
                        Console.WriteLine("Ti alzi cercando di colpire uno di loro ma questo ti spara in testa senza difficoltà");
                        Console.WriteLine("SEI MORTO!");
                    }
                    if (FightorNot == "2")
                    {
                        Console.WriteLine("Consegni tutto quello che hai");
                        Console.WriteLine("Loro vanno via ridendo di te e lasciandoti nudo come un verme");
                        Console.WriteLine("Cosa fai?");
                        Console.WriteLine("1. Provi a colpirli alle spalle");
                        Console.WriteLine("2. Resti a letto a piangere");
                        Console.WriteLine("3. Aspetti per poi andare alla ricerca di un kinder ");
                        Console.WriteLine("                                            ");
                        string nuked = Console.ReadLine();

                        if (nuked == "1")
                        {
                            Console.WriteLine("Ti alzi arrabbiato e cerchi di colpire la testa di uno di loro con un bastone di legno");
                            Console.WriteLine("Ti sparano in testa");
                            Console.WriteLine("SEI MORTO");
                            Console.WriteLine("                             ");
                        }

                        if (nuked == "2")
                        {
                            Console.WriteLine("Continui a piangere ma il territorio non è adatto ad una persona senza vestiti");
                            Console.WriteLine("In poco tempo cominci a tossire e a sentirti sempre più debole");
                            Console.WriteLine("SEI MORTO");
                            Console.WriteLine("                             ");
                        }

                        if (nuked == "3")
                        {
                            Console.WriteLine("Meglio aspettare qualche minuto prima di mettersi in viaggio, nudo ma fiero di te stesso");
                            Console.WriteLine("Vai dalla parte opposta a loro per cercare i tuoi kinder");
                            Console.WriteLine("Fortunatamente ti è rimasto qualcosa da mangiare e da bere");
                            Console.WriteLine("Trovi una vecchia auto abbandonata");
                            Console.WriteLine("Cosa fai?");
                            Console.WriteLine("1. Preferisci stare lontano e continuare la strada");
                            Console.WriteLine("2. Ti avvicini per controllare, magari trovi qualcosa di utile");
                            Console.WriteLine("3. Sembra un ottimo alloggio per un pisolino");
                            Console.WriteLine("                                            ");
                            string car = Console.ReadLine();

                            if (car == "1")
                            {
                                Console.WriteLine("Pensi non sia utile controllare");
                                Console.WriteLine("Continui a camminare, sei ancora nudo ma la situazione non ti spaventa");
                                Console.WriteLine("Vedi non molto lontano da te un signore con due bambine");
                                Console.WriteLine("Cosa fai?");
                                Console.WriteLine("1. Ti avvicini per chiedere aiuto");
                                Console.WriteLine("2. Preferisci stare lontano e continuare la strada");
                                Console.WriteLine("                                            ");
                                string family = Console.ReadLine();

                                if (family == "1")
                                {
                                    Console.WriteLine("Decidi di avvicinarti per chiedere aiuto");
                                    Console.WriteLine("Ma sei nudo e vieni scambiato per un maniaco");
                                    Console.WriteLine("Una bambina ti spara, lasciandoti a terra e lentamente perdi conoscenza");
                                    Console.WriteLine("SEI MORTO");
                                    Console.WriteLine("                             ");
                                }

                                if (family == "2")
                                {
                                    Console.WriteLine("Decidi di stare lontano, sei ancora nudo, forse è meglio non avvicinarsi");
                                    Console.WriteLine("Continui a camminare, trovi un casa, sembra abitata");
                                    Console.WriteLine("Cosa fai?");
                                    Console.WriteLine("1. Bussi alla porta");
                                    Console.WriteLine("2. Cerchi di entrare furtivamente dalla finestra");
                                    Console.WriteLine("3. Resti lontano");
                                    Console.WriteLine("                                            ");
                                    string NakedHouse = Console.ReadLine();

                                    if (NakedHouse == "1")
                                    {
                                        Console.WriteLine("Ti aprono la porta lentamente");
                                        Console.WriteLine("Hai trovato il covo dei satanisti");
                                        Console.WriteLine("Sei ancora nudo e per qualche strano motivo ti scambiano per uno di loro");
                                        Console.WriteLine("Ti accolgono, ti danno dei vestiti e TANTISSIMI KINDER");
                                        Console.WriteLine("                 ");
                                        Console.WriteLine("                 ");
                                        Console.WriteLine("SEI STATO BRAVO");
                                        Console.WriteLine("ADESSO PUOI AVERE TUTTI I KINDER CHE VORRAI");
                                        Console.WriteLine("ANCHE QUESTA GIORNATA E' FINITA BENE");
                                        Console.WriteLine("MANGI I KINDER E SEI FELICE");
                                        Console.WriteLine("                  ");
                                        Console.WriteLine("                  ");
                                        Console.WriteLine("--------------------------------------------");
                                        Console.WriteLine("--------------- HAI VINTO! -----------------");
                                        Console.WriteLine("--------------------------------------------");
                                    }

                                    if (NakedHouse == "2")
                                    {
                                        Console.WriteLine("Trovi una finestra aperta e cerchi di entrare");
                                        Console.WriteLine("Ti sentono e ti sparano a vista");
                                        Console.WriteLine("SEI MORTO");
                                        Console.WriteLine("                     ");
                                    }

                                    if (NakedHouse == "3")
                                    {
                                        Console.WriteLine("Decidi di non avvicinarti e continui il tuo viaggio");
                                        Console.WriteLine("Sfortunatamente sei rimasto nudo troppo tempo e non riesci a resistere al clima");
                                        Console.WriteLine("Ti senti sempre più stanco fino a perdere conoscenza");
                                        Console.WriteLine("SEI MORTO");
                                        Console.WriteLine("                     ");
                                    }

                                }
                            }

                            if (car == "2")
                            {
                                Console.WriteLine("Pensi sia utile controllare l'auto");
                                Console.WriteLine("Trovi solamente dei vestiti usati ma in buone condizioni");
                                Console.WriteLine("Hai la possibilità di vestirti prima di continuare il viaggio");
                                Console.WriteLine("Cosa fai?");
                                Console.WriteLine("1. Ti vesti");
                                Console.WriteLine("2. Prosegui il tuo viaggio nudo");
                                Console.WriteLine("                                            ");
                                string clothes = Console.ReadLine();

                                if (clothes == "1")
                                {
                                    Console.WriteLine("Finalmente riesci a trovare dei vestiti");
                                    Console.WriteLine("Arriva una tempesta di sabbia");
                                    Console.WriteLine("Fortunatamente vedi una casa vicina, sembra abitata");
                                    Console.WriteLine("Cosa fai?");
                                    Console.WriteLine("1. Bussi alla porta");
                                    Console.WriteLine("2. Decidi di stare lontano");
                                    Console.WriteLine("3. Cerchi di entrare furtivamente dalla finestra");
                                    Console.WriteLine("                                            ");
                                    string clothesHouse = Console.ReadLine();

                                    if (clothesHouse == "1")
                                    {
                                        Console.WriteLine("                 ");
                                        Console.WriteLine("Hai bussato ma è stata una scelta stupida");
                                        Console.WriteLine("Hai trovato la tana dei satanisti");
                                        Console.WriteLine("Senza darti il tempo di parlare ti danno una coltellata allo stomaco per poi sacrificarti");
                                        Console.WriteLine("SEI MORTO");
                                        Console.WriteLine("                 ");
                                    }

                                    if (clothesHouse == "2")
                                    {
                                        Console.WriteLine("                 ");
                                        Console.WriteLine("Pensi sia meglio stare lontano ma la tempesta è troppo forte");
                                        Console.WriteLine("In poco tempo perdi conoscenza");
                                        Console.WriteLine("SEI MORTO");
                                        Console.WriteLine("                     ");
                                    }

                                    if (clothesHouse == "3")
                                    {
                                        Console.WriteLine("                 ");
                                        Console.WriteLine("Fortunatamente trovi una finestra aperta ed entri senza farti sentire");
                                        Console.WriteLine("Vedi molta gente incappucciata, sembrano dei satanisti che stanno sacrificando qualcuno");
                                        Console.WriteLine("Cosa fai?");
                                        Console.WriteLine("1. Li ignori, cerchi di trovare dei kinder");
                                        Console.WriteLine("2. Li interrompi e cerchi di salvare quel ragazzo");
                                        Console.WriteLine("                              ");
                                        string SaveTheGuy = Console.ReadLine();

                                        if (SaveTheGuy == "1")
                                        {
                                            Console.WriteLine("                 ");
                                            Console.WriteLine("Tutti sono impegnati e distratti, è il momento migliore per cercare in casa");
                                            Console.WriteLine("FINALMENTE TROVI UN KINDER MAXI E LO METTI IN TASCA");
                                            Console.WriteLine("Cosa fai?");
                                            Console.WriteLine("1. Continui a cercare, sicuramente non sarà l'unico");
                                            Console.WriteLine("2. Vai via, un kinder ti basta");
                                            Console.WriteLine("                              ");
                                            string kinder = Console.ReadLine();

                                            if (kinder == "1")
                                            {
                                                Console.WriteLine("                 ");
                                                Console.WriteLine("L'avarizia non conosce pietà");
                                                Console.WriteLine("Ti hanno scoperto e verrai sacrificato pure tu");
                                                Console.WriteLine("SEI MORTO");
                                                Console.WriteLine("                 ");
                                            }

                                            if (kinder == "2")
                                            {
                                                Console.WriteLine("                 ");
                                                Console.WriteLine("SEI STATO BRAVO");
                                                Console.WriteLine("PUOI TORNARE A CASA COL TUO KINDER");
                                                Console.WriteLine("ANCHE QUESTA GIORNATA E' FINITA BENE");
                                                Console.WriteLine("MANGI IL KINDER E SEI FELICE");
                                                Console.WriteLine("                  ");
                                                Console.WriteLine("                  ");
                                                Console.WriteLine("--------------------------------------------");
                                                Console.WriteLine("--------------- HAI VINTO! -----------------");
                                                Console.WriteLine("--------------------------------------------");
                                            }

                                        }

                                        if (SaveTheGuy == "2")
                                        {
                                            Console.WriteLine("                 ");
                                            Console.WriteLine("Hai provato a salvarlo ma gli eroi non sempre finiscono bene");
                                            Console.WriteLine("Loro sono in maggioranza e senza difficoltà riescono a catturarti");
                                            Console.WriteLine("Verrai sacrificato");
                                            Console.WriteLine("SEI MORTO");
                                            Console.WriteLine("                 ");
                                        }

                                    }

                                }

                                if (car == "3")
                                {
                                    Console.WriteLine("Decidi di raggiungere l'auto per dormire un po'");
                                    Console.WriteLine("Ti svegli con una pistola puntata in testa");
                                    Console.WriteLine("SEI MORTO");
                                }
                            }
                        }
                    }
                }
                
            }
            else { Console.WriteLine("Antipatico"); }

            static void ToSecondHouse()
            {
                Console.WriteLine("                                  ");
                Console.WriteLine("Vuoi bussare?");
                Console.WriteLine("1. Bussa");
                Console.WriteLine("2. Continua per la tua strada");
                Console.WriteLine("3. Prova ad entrare dalla finestra senza farti vedere");
                Console.WriteLine("                                  ");
                string SecondHouse = Console.ReadLine();

                if (SecondHouse == "1")
                {
                    Console.WriteLine("                 ");
                    Console.WriteLine("Hai bussato ma è stata una scelta stupida");
                    Console.WriteLine("Hai trovato la tana dei satanisti");
                    Console.WriteLine("Senza darti il tempo di parlare ti danno una coltellata allo stomaco per poi sacrificarti");
                    Console.WriteLine("SEI MORTO");
                    Console.WriteLine("                 ");
                }

                if (SecondHouse == "2")
                {
                    Console.WriteLine("                 ");
                    Console.WriteLine("Continui per la tua strada convinto che avvicinarsi alla casa sia una pessima idea");
                    Console.WriteLine("Sfortunatamente arriva una tempesta di sabbia");
                    Console.WriteLine("Cerchi di raggiungere un riparo ma in poco tempo perdi conoscenza");
                    Console.WriteLine("SEI MORTO");
                    Console.WriteLine("                 ");
                }

                if (SecondHouse == "3")
                {
                    Console.WriteLine("                 ");
                    Console.WriteLine("Fortunatamente trovi una finestra aperta ed entri senza farti sentire");
                    Console.WriteLine("Vedi molta gente incappucciata, sembrano dei satanisti che stanno sacrificando qualcuno");
                    Console.WriteLine("Cosa fai?");
                    Console.WriteLine("1. Li ignori, cerchi di trovare dei kinder");
                    Console.WriteLine("2. Li interrompi e cerchi di salvare quel ragazzo");
                    Console.WriteLine("                              ");
                    string SaveTheGuy = Console.ReadLine();

                    if (SaveTheGuy == "1")
                    {
                        Console.WriteLine("                 ");
                        Console.WriteLine("Tutti sono impegnati e distratti, è il momento migliore per cercare in casa");
                        Console.WriteLine("FINALMENTE TROVI UN KINDER MAXI E LO METTI IN TASCA");
                        Console.WriteLine("Cosa fai?");
                        Console.WriteLine("1. Continui a cercare, sicuramente non sarà l'unico");
                        Console.WriteLine("2. Vai via, un kinder ti basta");
                        Console.WriteLine("                              ");
                        string kinder = Console.ReadLine();

                        if (kinder == "1")
                        {
                            Console.WriteLine("                 ");
                            Console.WriteLine("L'avarizia non conosce pietà");
                            Console.WriteLine("Ti hanno scoperto e verrai sacrificato pure tu");
                            Console.WriteLine("SEI MORTO");
                            Console.WriteLine("                 ");
                        }

                        if (kinder == "2")
                        {
                            Console.WriteLine("                 ");
                            Console.WriteLine("SEI STATO BRAVO");
                            Console.WriteLine("PUOI TORNARE A CASA COL TUO KINDER");
                            Console.WriteLine("ANCHE QUESTA GIORNATA E' FINITA BENE");
                            Console.WriteLine("MANGI IL KINDER E SEI FELICE");
                            Console.WriteLine("                  ");
                            Console.WriteLine("                  ");
                            Console.WriteLine("--------------------------------------------");
                            Console.WriteLine("--------------- HAI VINTO! -----------------");
                            Console.WriteLine("--------------------------------------------");
                        }

                    }

                    if (SaveTheGuy == "2")
                    {
                        Console.WriteLine("                 ");
                        Console.WriteLine("Hai provato a salvarlo ma gli eroi non sempre finiscono bene");
                        Console.WriteLine("Loro sono in maggioranza e senza difficoltà riescono a catturarti");
                        Console.WriteLine("Verrai sacrificato");
                        Console.WriteLine("SEI MORTO");
                        Console.WriteLine("                 ");


                    }
                }
            }
        }
    }
}
