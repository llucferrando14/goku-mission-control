# Kallax — Definició i Gamificació en Context Corporatiu

## TFG 2025-2026 | Lluc Ferrando Jordà
**Tutor:** [Nom del tutor]  
**Universitat:** Universitat de Barcelona — Escola de Noves Tecnologies Interactives  
**Grau:** Grau en Creació Artística per a Videojocs i Jocs Aplicats

---

## 1. QUÈ ÉS KALLAX

### 1.1 Definició Core

**Kallax** és un **job type** (tipus de feina) de picking i sorting per a magatzems, dissenyat per a **workflows de multi-order sorting** on els productes **NO estan pre-classificats** en sets. A diferència dels job types Sets/Sets+1, Kallax permet als treballadors processar múltiples comandes simultàniament en slots físics d'una prestatgeria, amb el sistema assignant dinàmicament productes a comandes a mesura que es van escanejant.

**En una frase:** Kallax transforma el processament de comandes de magatzem d'un flux lineari (una comanda cada cop) a un flux paral·lel gamificable (múltiples comandes en joc simultàniament).

### 1.2 El Problema que Resol

**Problema:** Els sistemes tradicionals de picking (Sets) requereixen que els productes estiguin pre-organitzats per comanda abans d'arribar al picker. Això és eficient només quan les comandes són grans i estàndard. Quan les comandes són petites, variades i dinàmiques (e-commerce modern), pre-classificar és lent i poc flexible.

**Solució Kallax:** 
- Els productes arriben **sense classificar** en una bossa (handbag)
- El picker **escaneja** cada producte i el sistema li indica **quina comanda** necessita aquell producte
- El picker **col·loca** el producte en el **slot assignat** a aquella comanda (4×4 prestatgeria = 16 comandes simultànies)
- Quan una comanda està completa, es **imprimeix l'etiqueta** i es **empaqueta**

**Resultat:** Més comandes processades en paral·lel, menor temps de manipulació, major flexibilitat.

### 1.3 Context i Usuaris

**Context d'operació:**
- **Entorn:** Magatzem logístic (Amphora Logistics)
- **Infraestructura:** Prestatgeria 4×4 slots, escàner de codi de barres, impressora ZPL, sistema informàtic (client web)
- **Durada:** Sessió contínua fins completar totes les comandes d'una handbag (15-45 minuts típicament)

**Tipus d'usuaris:**
1. **Picker/Operari:** Treballador de magatzem que executa el picking (rol principal)
2. **Supervisor:** Monitoritza productivitat i resol incidències
3. **Sistema:** Assigna slots, calcula progrés, valida escaneigs

### 1.4 Flux d'Experiència Actual (Pre-gamificació)

```
┌─────────────────────────────────────────────────────────────┐
│ FASE 1: CARREGAR HANDGAG                                    │
│ Acció: Operari escaneja ID de handbag                      │
│ Sistema: Carrega 16 comandes, mostra llista de productes   │
│ UI: Llista de productes amb codis QR i barres              │
└──────────────────┬──────────────────────────────────────────┘
                   │
                   ▼
┌─────────────────────────────────────────────────────────────┐
│ FASE 2: SORTING DE PRODUCTES                                │
│ Acció: Operari escaneja producte → Sistema indica slot     │
│        Operari col·loca producte al slot → Feedback visual │
│ Repetir: Fins completar tots els productes                 │
│ UI: Slots amb colors (buit/assignat/pendent/complet)       │
│     Llista de productes suggerits                          │
└──────────────────┬──────────────────────────────────────────┘
                   │
                   ▼
┌─────────────────────────────────────────────────────────────┐
│ FASE 3: IMPRESSIÓ D'ETIQUETES                               │
│ Trigger: Slot canvia a "complet" (tots els productes)      │
│ Acció: Sistema imprimeix etiqueta d'enviament (ZPL)        │
│ UI: Overlay indica escanejar etiqueta impresa              │
└──────────────────┬──────────────────────────────────────────┘
                   │
                   ▼
┌─────────────────────────────────────────────────────────────┐
│ FASE 4: PACKING I COMPLECIÓ                                 │
│ Acció: Operari escaneja etiqueta impresa                   │
│        Sistema valida → Marca comanda com a packed         │
│        Si és l'última comanda → Job complet                │
│ UI: Overlay amagat, missatge de finalització               │
└─────────────────────────────────────────────────────────────┘
```

### 1.5 Kallax en LBE + Themed Entertainment

**Argument de posicionament acadèmic:**

Kallax es situa en la **intersecció** de Location Based Entertainment i Themed Entertainment, adaptant principis d'ambdós camps a un **context corporatiu no-lúdic**.

**Característiques compartides amb LBE:**

| Característica LBE | Implementació a Kallax |
|-------------------|------------------------|
| Presencialitat física | Treball obligatori en estació de picking específica |
| Espai dissenyat | Prestatgeria 4×4 com a "game board" físic |
| Temporalitat | Sessió de treball amb inici, desenvolupament i fi clars |
| Interacció tangible | Escaneig físic, col·locació de productes reals |
| Communalitat | Potencial per treball en equip (multiple pickers) |

**Característiques compartides amb Themed Entertainment:**

| Característica TE | Potencial a Kallax |
|-------------------|---------------------|
| Storyliving | Narrativa de "Misión: Clasificar Pedidos" |
| Environmental storytelling | Disseny de magatzem com a "zona de joc" |
| Coherència temàtica | Colors, senyalització, ambientació tematitzada |
| Agència participant | Estratègia de quin producte agafar primer |

**On divergeix (context corporatiu):**
- **No és oci:** És treball productiu amb objectius logístics reals
- **No és voluntari:** Els treballadors han de completar el job
- **Ètica diferent:** La gamificació no pot amagar precarietat laboral
- **ROI empresarial:** L'objectiu final és eficiència, no només diversió

**Per què aquest posicionament és defensable acadèmicament:**

La literatura de LBE i Themed Entertainment (TEA, 2022; Pine & Gilmore, 2011) ja reconeix que aquests principis són aplicables més enllà de l'oci: museus, retail, educació, i **entorns laborals**. Kallax representa una aplicació professional de principis d'experiència dissenyada.

### 1.6 Elements de Gamificació Actuals (Si n'hi ha)

**Elements ja presents (subtils):**
1. **Feedback immediat:** Slots canvien de color quan es col·loca producte
2. **Progrés visible:** Barres de progrés per ordres i slots
3. **Suggeriments algorítmics:** Productes suggerits basats en prioritats
4. **Estats visuals:** Empty → Assigned → Pending → Complete (progressió)

**El que falta (oportunitats de gamificació):**
1. **Recompenses explícites:** Punts, nivells, insígnies
2. **Narrativa:** Context fictici que doni sentit a la tasca
3. **Social:** Comparació amb companys, treball en equip
4. **Desafiament:** Objectius opcionals, "missions especials"
5. **Flow optimization:** Ritme, dificultat escalonada, sorpreses
6. **Ownership:** Sentiment de progrés personal persistent

**Gap d'engagement:** El sistema actual és **funcional però avorrit**. Compleix la seva funció logística però no maximitza la motivació intrínseca dels treballadors. Això resulta en:
- Rotació alta de personal
- Productivitat variable
- Errors per desatenció
- Baixa satisfacció laboral

---

## 2. COM INTRODUIR GAMIFICACIÓ A KALLAX

### 2.1 Definició de Gamificació en Context Kallax

**Què és la gamificació AQUÍ:**

No és un joc superficial superposat al treball. És el **disseny intencionat de la experiència de treball** aplicant principis de disseny de jocs per maximitzar:
1. **Flow** (immersió en la tasca)
2. **Competència** (sentiment de millora)
3. **Autonomia** (elecció i control)
4. **Relació** (connexió amb l'equip)

**Constriccions del context corporatiu:**

| Constricció | Implicació per al disseny |
|-------------|---------------------------|
| **Temps productiu** | La gamificació no pot ralentir el picking |
| **Obliagtorietat** | Els treballadors NO poden optar per no participar |
| **Dades personals** | El tracking ha de ser ètic i transparent |
| **Diversitat d'usuaris** | Ha de funcionar per a diferents edats, habilitats, motivacions |
| **Escalabilitat** | Ha de funcionar amb 10 o 1000 treballadors |

**Objectius de la gamificació a Kallax:**

1. **Engagement:** Reduir l'avorriment de tasques repetitives
2. **Precisió:** Reduir errors per distracció
3. **Velocitat:** Millorar throughput (ordres/hora)
4. **Retenció:** Reduir rotació de personal
5. **Satisfacció:** Millorar experiència laboral (mesurable amb enquestes)

### 2.2 Mecàniques de Gamificació Aplicables a Kallax

#### **Mecànica 1: Sistemes de Progrés (Progression Systems)**

**Què és:** Visualització clara del progrés cap a objectius.

**Implementació a Kallax:**
- **Nivells d'operari:** Novice → Pickler → Speedster → Master Picker → Legend (noms temàtics)
- **XP (Experience Points):** Guanyar punts per cada producte escanejat, ordre completada, accuracy streak
- **Bars de progrés:** Visualització del progrés cap al següent nivell
- **Missions diàries:** "Completa 20 ordres avui" (repte personalitzat)

**Implementació tècnica:**
```javascript
// Exemple conceptual
const xpGained = {
  productScanned: 10,
  orderCompleted: 50,
  perfectAccuracy: 25,
  streakBonus: 5 * streakCount
};

const levelThresholds = {
  1: 0,      // Novice
  2: 500,    // Pickler  
  3: 1500,   // Speedster
  4: 3000,   // Master Picker
  5: 5000    // Legend
};
```

**Resposta esperada de l'usuari:**
- "Només em falten 50 XP per pujar de nivell, faré una comanda més"
- Satisfacció de completar la barra de progrés

**Risc:** Obsessió amb nivells per sobre de qualitat.
**Mitigació:** XP bonus per accuracy, no només velocitat.

---

#### **Mecànica 2: Loops de Feedback (Feedback Loops)**

**Què és:** Resposta immediata i multimodal a cada acció.

**Implementació a Kallax:**
- **Visual:** 
  - Animacions de slots (pop, glow, pulse)
  - Partícules en completar ordre
  - Números flotants "+10 XP" en escanejar
- **Auditiu:**
  - So satisfactori en escaneig correcte
  - Melodia curta en completar ordre
  - Alerta suau en error (no agressiva)
- **Hàptic:**
  - Vibració curta en dispositius mòbils (si aplica)

**Implementació tècnica:**
```javascript
// Pseudocodi
onProductScanned() {
  playSound('success_scan.mp3');        // ~100ms
  showParticleEffect(slot.position);     // 500ms
  displayFloatingText('+10 XP', slot);  // 1s fade
  animateSlot(slot, 'pulse');            // 300ms
}
```

**Resposta esperada:**
- Dopamina per cada acció correcta
- Ritme satisfactori (com tocar un instrument)
- Consciència immediata d'èxit vs error

**Inspiració:** Bottle Bank Arcade (Volkswagen) — cada acció té feedback sonor i visual immediat.

---

#### **Mecànica 3: Mecàniques Socials (Social Mechanics)**

**Què és:** Elements que connecten el treballador amb els companys.

**Implementació a Kallax:**

**A. Leaderboards constructius:**
- **Weekly Accuracy Leaderboard:** Top 10 per precisió (no velocitat)
- **Team Challenges:** "Equipo A vs Equipo B, qui completa més ordres aquesta setmana?"
- **Personal Bests:** Comparació amb un mateix, no amb altres

**B. Col·laboració:**
- **Bonus d'equip:** Si tot l'equip completa les seves metes, tots reben bonus XP
- **Help System:** Poder "cridar" a un company per ajuda (gamificar la col·laboració)

**C. Reconeixement:**
- **Kudos:** Sistema de "aplaudiments" entre companys
- **MVP de la setmana:** Reconeixement públic del millor picker

**Implementació tècnica:**
```javascript
// Leaderboard calculat cada nit
const weeklyLeaderboard = calculateTop(
  workers, 
  metric='accuracy',  // NO 'speed' sol
  period='this_week'
);

// Team challenge
if (teamA.ordersCompleted > teamB.ordersCompleted) {
  awardXP(teamA.members, bonus=100);
}
```

**Resposta esperada:**
- Sentiment de pertinença a equip
- Competició sana (no destructiva)
- Suport mutu per assolir objectius

**Risc:** Competició tòxica, bullying a qui va més lent.
**Mitigació:** 
- Leaderboards per accuracy, no només velocitat
- Equips rotatius (no fixes)
- Èmfasi en "superar el teu propi record"

---

#### **Mecànica 4: Capa Narrativa (Narrative Layer)**

**Què és:** Una història o tema que dóna context i sentit a la tasca.

**Implementació a Kallax (opcions):**

**Opció A: "Space Station Sorting"**
- **Tema:** Ets un oficial d'una estació espacial que ha de classificar subministraments per a diferents mòduls
- **Slots:** "Mòdul Alfa", "Mòdul Beta", etc.
- **Ordres:** "Paquet de subministraments per al Mòdul Mèdic"
- **Nivells:** Cadet → Pilot → Capità → Comandant → Almirall

**Opció B: "Master Chef Kitchen"** (inspirat en Overcooked)
- **Tema:** Eres un cuiner en una cuina caòtica que ha de preparar comandes
- **Slots:** Taules de clients diferents
- **Productes:** Ingredients
- **Ordres:** Plats a preparar

**Opció C: Minimalista professional**
- **Tema:** "Elite Logistics Operator"
- **Sense ficció:** Professionalisme, eficiència, perfecció
- **Nivells:** Junior → Senior → Expert → Master → Legend

**Implementació tècnica:**
```javascript
// Configuració de tema
const theme = {
  name: 'Space Station',
  slotNames: ['Alpha', 'Beta', 'Gamma', 'Delta', ...],
  levelNames: ['Cadet', 'Pilot', 'Captain', 'Commander', 'Admiral'],
  orderNames: 'Supply Packages',
  backgroundMusic: 'ambient_space.mp3',
  soundEffects: {
    scan: 'laser_scan.mp3',
    complete: 'mission_accomplished.mp3'
  }
};
```

**Resposta esperada:**
- Major immersió en la tasca
- Sentiment de "jugar un rol" (storyliving)
- Reducció de percepció de "treball avorrit"

**Risc:** Narrativa infantil pot ser alienant per a treballadors adults.
**Mitigació:** Provar amb grups focals. Opció C (professional) és més segura.

---

#### **Mecànica 5: Disseny de Desafiaments (Challenge Design)**

**Què és:** Objectius opcionals que afegeixen dificultat i recompensa.

**Implementació a Kallax:**

**A. Streaks:**
- **"Perfect Streak":** 10 productes escanejats sense error → Bonus XP
- **"Speed Streak":** 5 ordres completades en menys de X minuts → Bonus

**B. Missions especials:**
- **"Rush Hour":** Completa 3 ordres en 10 minuts
- **"Accuracy Challenge":** 100% accuracy en tota la handbag
- **"Team Player":** Ajuda a completar una ordre d'un company

**C. Nivells de dificultat:**
- **Mode Normal:** Actual
- **Mode Rush:** Més productes, menys temps (opcional, voluntari)
- **Mode Zen:** Sense pressió temporal (per a formació)

**Implementació tècnica:**
```javascript
// Sistema de missions
const dailyMissions = [
  {
    id: 'perfect_streak_10',
    description: '10 productes sense error',
    reward: 50,
    condition: (stats) => stats.currentStreak >= 10
  },
  {
    id: 'speed_demon',
    description: '3 ordres en 10 minuts',
    reward: 100,
    condition: (stats) => stats.ordersInLast10Min >= 3
  }
];
```

**Resposta esperada:**
- Auto-desafiament per a operaris avançats
- Variedad en el treball repetitiu
- Satisfacció de completar reptes

---

#### **Mecànica 6: Onboarding Gamificat**

**Què és:** Convertir l'aprenentatge inicial en tutorial de joc.

**Implementació a Kallax:**
- **Tutorial interactiu:** Primer dia = "Missions d'entrenament" amb guia pas a pas
- **Nivell 1 bloquejat:** Certes funcions només disponibles al pujar de nivell (progressive disclosure)
- **Mentor virtual:** Avatar que explica mecàniques (poder desactivar)
- **Pràctica segura:** Mode "Training" sense conseqüències reals

**Resposta esperada:**
- Reducció de la corba d'aprenentatge
- Menys ansietat el primer dia
- Millor retenció de procediments

---

### 2.3 Mecàniques a EVITAR en Context Corporatiu

**PER QUÈ evitar-les:** Poden crear pressió excessiva, competència destructiva, o ètica laboral qüestionable.

#### **❌ Competició Forçada Individual**

**Problema:** Leaderboards públics de "qui és més ràpid" creen:
- Ansietat per als treballadors més lents
- Cultura de culpa
- Risc d'accidents per pressió
- Discriminació encoberta

**Alternativa:** Leaderboards d'accuracy (tots poden ser precisos) o competició d'equips (suport mutu).

**Base acadèmica:** Self-Determination Theory (Deci & Ryan, 2000) — la competència ha de sentir-se com a creixement personal, no comparació humiliant.

---

#### **❌ Mecàniques Punitives (Punishment Mechanics)**

**Problema:** Perdre punts, "vides", o estatus per errors:
- Crea por, no motivació
- Amaga errors per por a pèrdues
- Redueix psicològic safety

**Alternativa:** Framing positiu — "guanya bonus per accuracy" en comptes de "perd punts per errors".

**Base acadèmica:** Loss Aversion (Kahneman & Tversky, 1979) — les pèrdues percebudes són 2x més potents que els guanys equivalents. Ús èticament qüestionable en entorns laborals.

---

#### **❌ Recompenses Només Extrínseques**

**Problema:** Si tot és per diners/bonus, es mata la motivació intrínseca:
- Overjustification Effect (Lepper et al., 1973)
- Quan les recompenses extrínseques desapareixen, la motivació cau per sota del nivell inicial

**Alternativa:** Equilibri 80% intrínsec (reconeixement, progrés) + 20% extrínsec (bonus opcionals).

**Base acadèmica:** Deci (1971) — pagament per tasques intrínsecament interessants redueix el gust per la tasca.

---

#### **❌ Public Failure / Shaming**

**Problema:** Mostrar públicament qui va "últim" o qui té "menys punts":
- Humiliació
- Resentiment
- Rotació de personal

**Alternativa:** Privacitat per defecte. Comparacions només amb un mateix.

---

#### **❌ Gamificació d'Occupational Health Risks**

**Problema:** Gamificar hores extres, treball ràpid en condicions insegures, o ignorar senyals de fatiga:
- Risc físic real
- Responsabilitat legal
- Ètica empresarial qüestionable

**Red line:** La gamificació MAI ha de prioritza velocitat sobre seguretat física.

---

### 2.4 Fulla de Ruta d'Implementació Progressiva

**Filosofia:** Implementar per fases, mesurant impacte a cada pas.

#### **FASE 1: Fonaments (Setmanes 1-4)**

**Objectiu:** Afegir feedback immediat i progrés bàsic sense canviar el flux de treball.

**Implementacions:**
- ✅ Animacions de slots (pop, glow)
- ✅ So en escaneig correcte
- ✅ Números flotants "+XP"
- ✅ Barra de progrés personal (nivell 1-5)
- ✅ Missatges de feedback ("Great!", "Perfect!")

**Mètriques a mesurar:**
- Temps mitjà per ordre
- Taxa d'error
- Enquesta de satisfacció (1-10)

**Èxit:** Productivitat mantinguda o millorada + satisfacció millorada.

---

#### **FASE 2: Capa Social (Setmanes 5-8)**

**Objectiu:** Afegir elements socials (si la Fase 1 va bé).

**Implementacions:**
- ✅ Leaderboard d'accuracy (top 10, voluntari)
- ✅ Reptes d'equip setmanals
- ✅ Sistema de "kudos" entre companys
- ✅ Reconeixement públic del "MVP de la setmana"

**Mètriques a mesurar:**
- Moral de l'equip (enquesta grupal)
- Cohesió d'equip
- Retenció de personal

**Èxit:** Millora de moral sense competició destructiva.

---

#### **FASE 3: Capa Narrativa Avançada (Setmanes 9-12)**

**Objectiu:** Afegir narrativa temàtica (si Fases 1-2 van bé).

**Implementacions:**
- ✅ Selecció de tema (Space / Kitchen / Professional)
- ✅ Noms temàtics per nivells
- ✅ Sons ambientals de fons (opcional)
- ✅ "Missions especials" diàries amb narrativa
- ✅ Història de "per què" clasifiquem ordres

**Mètriques a mesurar:**
- Engagement (temps en plataforma)
- Retenció a llarg termini
- Qualitat del treball (feedback de supervisors)

**Èxit:** Treballadors reporten més "diversió" mantenint productivitat.

---

#### **FASE 4: Personalització (Mes 4+)**

**Objectiu:** Adaptar la gamificació a preferències individuals.

**Implementacions:**
- ✅ Perfils d'usuari (competitiu vs cooperatiu vs solitari)
- ✅ Reptes personalitzats segons habilitat
- ✅ Recompenses seleccionables
- ✅ Mode "Zen" per a qui prefereix treballar sense gamificació

**Mètriques a mesurar:**
- Ús de diferents modes
- Satisfacció segmentada
- Retenció a 6 mesos

---

## 3. ORIENTACIÓ DE LA TESI

### 3.1 Angle de Tesi Proposat

**La pregunta de recerca:**

> "Com poden aplicar-se els principis de disseny de Location Based Entertainment (LBE) i gamificació centrada en l'usuari per transformar processos de picking de magatzem en experiències de treball més engaging, eficients i satisfactòries, mantenint l'ètica laboral i la productivitat empresarial?"

**Contribució acadèmica original:**

Aquesta tesi proposa un **framework híbrid** que integra:
1. **Teoria de LBE/Themed Entertainment** (Pine & Gilmore, 2011; TEA, 2022)
2. **Frameworks de gamificació** (Octalysis, MDA, SDT, Flow)
3. **Context corporatiu específic** (logística de magatzem)

**Gap en literatura actual:**

La majoria de recerca en gamificació corporativa es centra en:
- Oficines (productivitat de coneixement)
- Formació (e-learning gamificat)
- Vendes (CRM gamification)

**Manca:** Estudis sobre gamificació en **treball manual repetitiu** (warehouse picking) aplicant principis d'**immersió espacial** (LBE).

**Proposta de tesi (format acadèmic):**

> "Aquesta tesi proposa el **'Kallax Framework'** com a model de disseny per aplicar principis de Location Based Entertainment i gamificació centrada en Flow i Self-Determination Theory a processos de picking de magatzem, demostrant que aquest enfocament millora significativament l'engagement dels treballadors i la precisió operativa sense comprometre la productivitat, en el context específic de la logística d'e-commerce."

---

### 3.2 Objectius SMART

**Objectiu General:**

> "Dissenyar i validar un sistema de gamificació basat en principis de LBE per al procés de picking Kallax, que millori l'experiència dels operaris de magatzem mantenint l'eficiència operativa."

**Objectius Específics (SMART):**

#### **OE1: Anàlisi Teòrica**
> "Elaborar un marc teòric que integri Location Based Entertainment, Themed Entertainment i gamificació aplicable a contextos logístics de magatzem, revisant mínim 40 referències acadèmiques i professionals, lliurat com a capítol de la tesi abans de [data]."

- **S**pecífic: Marc teòric amb 40+ referències
- **M**esurable: 40 referències documentades
- **A**ssolible: Sí, amb recerca acadèmica
- **R**elevant: Fonamenta la tesi
- **T**emporal: Abans de [data]

---

#### **OE2: Disseny del Sistema**
> "Dissenyar un sistema de gamificació per Kallax que incorpori mínim 5 mecàniques de joc (progressió, feedback, social, narrativa, desafiament), validat amb 3 experts en UX o gamificació abans de [data]."

- **S**pecífic: 5 mecàniques concretes
- **M**esurable: Validació per 3 experts
- **A**ssolible: Sí, amb prototipat
- **R**elevant: Producte principal de la tesi
- **T**emporal: Abans de [data]

---

#### **OE3: Prototipat Tècnic**
> "Implementar un prototip funcional del sistema de gamificació integrat amb Kallax, demostrant les mecàniques principals en un entorn de prova, lliurat abans de [data]."

- **S**pecífic: Prototip tècnic funcional
- **M**esurable: Demo funcional operativa
- **A**ssolible: Sí, amb Vue.js/CSS/JS
- **R**elevant: Prova de concepte
- **T**emporal: Abans de [data]

---

#### **OE4: Validació amb Usuaris**
> "Conduir tests d'usuari amb mínim 10 operaris de magatzem per avaluar l'experiència de la gamificació, mesurant satisfacció (enquesta SUS o similar), engagement (temps en plataforma) i percepció de càrrega de treball (NASA-TLX), abans de [data]."

- **S**pecífic: Tests amb 10 usuaris reals
- **M**esurable: SUS, engagement, NASA-TLX
- **A**ssolible: Sí, accés a operaris
- **R**elevant: Validació empírica
- **T**emporal: Abans de [data]

---

#### **OE5: Documentació i Marc de Treball**
> "Produir un document final de tesi seguint la plantilla oficial de l'ENIT-UB, incloent tots els capítols requerits (Introducció, Marc Teòric, Objectius, Estat de l'Art, Metodologia, Disseny, Desenvolupament, Resultats, Conclusions), lliurat abans del 31 de maig de 2026."

- **S**pecífic: Tesi completa segons plantilla
- **M**esurable: Tots els capítols complets
- **A**ssolible: Sí, amb planificació
- **R**elevant: Requisit acadèmic
- **T**emporal: 31/05/2026 (HARD DEADLINE)

---

### 3.3 Estructura Proposada del TFG

Mapeig de seccions oficials del template ENIT-UB al contingut d'aquesta tesi:

#### **1. INTRODUCCIÓ** (~5 pàgines)
- **1.1 Context i justificació:** El problema del picking avorrit, la revolució de l'experience economy
- **1.2 Objectius:** Els 5 OE SMART detallats
- **1.3 Abast i delimitacions:** Què inclou i què no inclou la tesi
- **1.4 Estructura de la memòria:** Resum de capítols

#### **2. MARC TEÒRIC** (~15 pàgines)
- **2.1 Location Based Entertainment (LBE):** Definició, història, principis
- **2.2 Themed Entertainment:** Definició TEA, storyliving, environmental storytelling
- **2.3 Gamificació:** Definició Deterding et al., frameworks (Octalysis, MDA, SDT, Flow, Fogg)
- **2.4 Gamificació Corporativa:** Casos d'èxit i fracàs, consideracions ètiques
- **2.5 Disseny de Jocs:** Referències a Overcooked, Unpacking, Papers Please

#### **3. OBJECTIUS** (~2 pàgines)
- **3.1 Objectiu General:** La proposta de tesi en una frase
- **3.2 Objectius Específics:** Detall dels 5 OE SMART
- **3.3 Hipòtesi de treball:** "La gamificació LBE millora engagement i precisió"

#### **4. ESTAT DE L'ART** (~20 pàgines)
- **4.1 Experiències LBE rellevants:** Bottle Bank Arcade, Sleep No More, Meow Wolf, etc.
- **4.2 Gamificació en contextos laborals:** Microsoft Language Game, SAP, Salesforce
- **4.3 Disseny de jocs aplicable:** Overcooked, Unpacking, anàlisi de mecàniques
- **4.4 Frameworks acadèmics:** Deterding, Hamari, Morschheuser, Burke
- **4.5 Taules comparatives:** Síntesi de referències per categoria

#### **5. ESTUDI DE COMPETÈNCIA** (~5 pàgines)
- **5.1 Competidors directes:** Sistemes de picking amb gamificació
- **5.2 Competidors indirectes:** Automatització robòtica
- **5.3 Mapa de posicionament:** On situa Kallax
- **5.4 Diferencial de Kallax:** Proposta de valor única

#### **6. METODOLOGIA** (~5 pàgines)
- **6.1 Tipus de recerca:** Disseny basat en recerca (Research through Design)
- **6.2 Fases del projecte:** Fase 1-4 descrites
- **6.3 Mètodes d'avaluació:** Enquestes SUS, NASA-TLX, mètriques quantitatives
- **6.4 Consideracions ètiques:** Consentiment informat, privacitat de dades

#### **7. DISSENY DE LA SOLUCIÓ** (~15 pàgines)
- **7.1 Anàlisi de Kallax actual:** Workflow, usuaris, punts de dolor
- **7.2 Proposta de gamificació:** Mecàniques detallades (5 mecàniques)
- **7.3 Framework Kallax:** Model teòric-pràctic
- **7.4 Consideracions d'implementació:** Tecnologia, escalabilitat, ètica

#### **8. DESENVOLUPAMENT** (~10 pàgines)
- **8.1 Arquitectura tècnica:** Stack tecnològic
- **8.2 Implementació del prototip:** Captures de pantalla, codi rellevant
- **8.3 Iteracions de disseny:** Canvis basats en feedback

#### **9. RESULTATS** (~8 pàgines)
- **9.1 Tests d'usuari:** Metodologia de tests
- **9.2 Dades quantitatives:** SUS scores, temps, accuracy
- **9.3 Feedback qualitatiu:** Quotes d'usuaris
- **9.4 Anàlisi:** Què funciona, què no, per què

#### **10. CONCLUSIONS** (~5 pàgines)
- **10.1 Conclusions generals:** Síntesi de descobriments
- **10.2 Contribució al coneixement:** Què aporta aquesta tesi
- **10.3 Limitacions:** Què no s'ha pogut fer
- **10.4 Treball futur:** Implementació real, altres contexts

#### **REFERÈNCIES** (~5 pàgines)
- Llista completa de 50+ referències en format APA/ISO

#### **ANNEXOS**
- **Annex A:** Preguntes d'entrevista / Enquesta SUS
- **Annex B:** Captures de pantalla addicionals
- **Annex C:** Codi font rellevant

---

### 3.4 Recomanació d'Idioma

**Opcions disponibles:** Català, Castellà, o Anglès

**Anàlisi per opció:**

| Idioma | Pros | Cons |
|--------|------|------|
| **Català** | Requisit institucional UB, tutor probablement prefereix, demostra competència lingüística | Menys accessible internacionalment, terminologia tècnica menys estàndard |
| **Castellà** | Més natural per a molts lecturers espanyols, més recursos acadèmics disponibles | No és l'idioma oficial del grau (verificar) |
| **Anglès** | Màxima difusió internacional, publicable en conferències/journals internacionals, terminologia estàndard | Requereix nivell alt, tutor ha de poder revisar |

**Recomanació:** **ANGLÈS** (primera opció) o **CATALÀ** (segona opció)

**Raonament:**
1. **Contribució acadèmica:** Aquesta tesi té potencial per ser publicada en venues internacionals (CHI Play, Gamification Conference, etc.) — només possible en anglès
2. **Terminologia:** "Location Based Entertainment", "Gamification", "Flow", "Self-Determination Theory" són termes establerts en anglès; traduccions poden crear confusió
3. **CV professional:** Tesi en anglès demostra competència internacional
4. **Tutor:** Consultar si el tutor pot revisar anglès; si no, català és segona opció viable

**Compromís:** Escriure en anglès però incloure resum extens en català i castellà.

---

## RESUM EXECUTIU

### Document 2: Què s'ha definit?

**1. Kallax:**
- Sistema de picking multi-order per a magatzems
- 16 comandes simultànies, assignació dinàmica
- Operat per Amphora Logistics

**2. Gamificació proposada:**
- 6 mecàniques principals documentades
- Enfoc en Flow, SDT, i engagement intrínsec
- 4 fases d'implementació progressiva

**3. Orientació de tesi:**
- **Angle:** Framework híbrid LBE + Gamificació per a picking
- **Objectius:** 5 SMART (anàlisi, disseny, prototip, tests, documentació)
- **Estructura:** 10 capítols segons plantilla ENIT-UB
- **Idioma recomanat:** Anglès (primera) o Català (segona)

### Següents Passos:

1. **Revisió per part de Lluc:** Confirmar angle de tesi amb tutor
2. **Ajustar objectius SMART:** Dates específiques segons calendari acadèmic
3. **Iniciar Fase 1:** Implementar mecàniques bàsiques (feedback + XP)
4. **Preparar tests d'usuari:** Contactar operaris de magatzem per a validació

---

*Document 2 de 2: Kallax Definició + Gamificació — COMPLET*

