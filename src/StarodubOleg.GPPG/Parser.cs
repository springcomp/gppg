// This code was generated by the Gardens Point Parser Generator
// Copyright (c) Wayne Kelly, John Gough, QUT 2005-2014
// (see accompanying GPPGcopyright.rtf)

// GPPG version 1.5.2
// Machine:  HOME
// DateTime: 01.10.2016 19:59:56
// UserName: Олег
// Input file <gppg.y - 01.10.2016 14:12:34>

// options: no-lines gplex

using System;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using System.Globalization;
using System.Text;
using QUT.Gppg;
using System.Collections;

namespace QUT.GPGen.Parser
{
internal enum Token {
    error=127,EOF=128,codeStart=129,codeEnd=130,ident=131,anchoredSymbol=132,
    number=133,filePath=134,litstring=135,verbatim=136,litchar=137,kwPCPC=138,
    kwLbrace=139,kwRbrace=140,kwToken=141,kwType=142,kwLeft=143,kwRight=144,
    kwNonassoc=145,kwPrec=146,kwStart=147,kwUnion=148,kwDefines=149,kwLocations=150,
    kwNamespace=151,kwPartial=152,kwOutput=153,kwShareTokens=154,kwImportTokens=155,kwParsertype=156,
    kwTokentype=157,kwScanbasetype=158,kwUsing=159,kwVisibility=160,kwYYSTYPE=161,kwYYLTYPE=162,
    kwCsTokenFile=163,maxParseToken=164,errTok=165};

internal partial struct ValueType
{ public int iVal; 
         public List<string> stringList;
         public List<TokenInfo> tokenList;
         public TokenInfo tokenInfo; 
         public Production prod;
         public ActionProxy proxy;
       }
// Abstract base class for GPLEX scanners
[GeneratedCodeAttribute( "Gardens Point Parser Generator", "1.5.2")]
internal abstract class ScanBase : AbstractScanner<ValueType,LexSpan> {
  private LexSpan __yylloc = new LexSpan();
  public override LexSpan yylloc { get { return __yylloc; } set { __yylloc = value; } }
  protected virtual bool yywrap() { return true; }
}

// Utility class for encapsulating token information
[GeneratedCodeAttribute( "Gardens Point Parser Generator", "1.5.2")]
internal class ScanObj {
  public int token;
  public ValueType yylval;
  public LexSpan yylloc;
  public ScanObj( int t, ValueType val, LexSpan loc ) {
    this.token = t; this.yylval = val; this.yylloc = loc;
  }
}

[GeneratedCodeAttribute( "Gardens Point Parser Generator", "1.5.2")]
internal partial class Parser: ShiftReduceParser<ValueType, LexSpan>
{
  // Verbatim content from gppg.y - 01.10.2016 14:12:34
/*
 *  Parser spec for GPPG
 *  gppg.y: Author: John Gough, August 2008
 *  Process with > GPPG /gplex /no-lines gppg.y
 */
  // End verbatim content from gppg.y - 01.10.2016 14:12:34

#pragma warning disable 649
  private static Dictionary<int, string> aliases;
#pragma warning restore 649
  private static Rule[] rules = new Rule[115];
  private static State[] states = new State[162];
  private static string[] nonTerms = new string[] {
      "TokenList", "TokenDecl", "NtSymbolList", "Symbols", "SymbolsOpt", "RightHandSide", 
      "RHStermList", "Action", "PrecOptAndAction", "Program", "$accept", "DefinitionSectionOpt", 
      "Divider", "RulesSection", "EpilogOpt", "CodeBlock", "Definitions", "Definition", 
      "Declaration", "KindOpt", "Kind", "NtSymbol", "TypeNameOpt", "UnionTypeConstructor", 
      "DottedName", "SemiOpt", "TypeConstructor", "CommaOpt", "BadSeparator", 
      "TypeArguments", "DeclList", "OneDecl", "TypeConstructorSeq", "ARule", 
      "RuleProlog", "AlternativesOpt", "SymOrLit", };

  static Parser() {
    states[0] = new State(new int[]{139,46,141,50,142,79,143,88,144,91,145,94,147,97,148,99,150,126,149,127,163,128,152,129,154,130,155,131,151,136,159,138,153,142,158,147,156,149,160,151,157,153,161,155,162,157,127,160,138,-11},new int[]{-10,1,-12,3,-17,44,-18,159,-19,49});
    states[1] = new State(new int[]{128,2});
    states[2] = new State(-1);
    states[3] = new State(new int[]{138,43},new int[]{-13,4});
    states[4] = new State(new int[]{132,39,127,42},new int[]{-14,5,-34,41,-35,13});
    states[5] = new State(new int[]{138,8,132,39,128,-6},new int[]{-15,6,-34,7,-35,13});
    states[6] = new State(-2);
    states[7] = new State(-91);
    states[8] = new State(new int[]{129,10,128,-8},new int[]{-16,9});
    states[9] = new State(-5);
    states[10] = new State(new int[]{130,11,127,12});
    states[11] = new State(-7);
    states[12] = new State(-9);
    states[13] = new State(new int[]{131,24,137,25,135,26,123,29,146,33,59,-98,124,-98},new int[]{-6,14,-7,19,-4,36,-37,27,-9,37,-8,28});
    states[14] = new State(-96,new int[]{-36,15});
    states[15] = new State(new int[]{59,16,124,17});
    states[16] = new State(-94);
    states[17] = new State(new int[]{131,24,137,25,135,26,123,29,146,33,59,-98,124,-98},new int[]{-6,18,-7,19,-4,36,-37,27,-9,37,-8,28});
    states[18] = new State(-97);
    states[19] = new State(new int[]{123,29,146,33,59,-99,124,-99},new int[]{-9,20,-8,28});
    states[20] = new State(new int[]{131,24,137,25,135,26,123,-103,146,-103,59,-103,124,-103},new int[]{-5,21,-4,22,-37,27});
    states[21] = new State(-102);
    states[22] = new State(new int[]{131,24,137,25,135,26,123,-104,146,-104,59,-104,124,-104},new int[]{-37,23});
    states[23] = new State(-106);
    states[24] = new State(-107);
    states[25] = new State(-108);
    states[26] = new State(-109);
    states[27] = new State(-105);
    states[28] = new State(-110);
    states[29] = new State(new int[]{129,10,125,-8,127,-8},new int[]{-16,30});
    states[30] = new State(new int[]{125,31,127,32});
    states[31] = new State(-113);
    states[32] = new State(-114);
    states[33] = new State(new int[]{131,34});
    states[34] = new State(new int[]{123,29,131,-112,137,-112,135,-112,146,-112,59,-112,124,-112},new int[]{-8,35});
    states[35] = new State(-111);
    states[36] = new State(new int[]{131,24,137,25,135,26,123,-100,146,-100,59,-100,124,-100},new int[]{-37,23});
    states[37] = new State(new int[]{131,24,137,25,135,26,123,-103,146,-103,59,-103,124,-103},new int[]{-5,38,-4,22,-37,27});
    states[38] = new State(-101);
    states[39] = new State(new int[]{58,40});
    states[40] = new State(-95);
    states[41] = new State(-92);
    states[42] = new State(-93);
    states[43] = new State(-4);
    states[44] = new State(new int[]{139,46,141,50,142,79,143,88,144,91,145,94,147,97,148,99,150,126,149,127,163,128,152,129,154,130,155,131,151,136,159,138,153,142,158,147,156,149,160,151,157,153,161,155,162,157,138,-10},new int[]{-18,45,-19,49});
    states[45] = new State(-13);
    states[46] = new State(new int[]{129,10,140,-8},new int[]{-16,47});
    states[47] = new State(new int[]{140,48});
    states[48] = new State(-16);
    states[49] = new State(-17);
    states[50] = new State(new int[]{60,74,131,-49,137,-49},new int[]{-20,51,-21,73});
    states[51] = new State(new int[]{131,55,137,59},new int[]{-1,52,-2,72});
    states[52] = new State(new int[]{44,61,59,62,58,63,60,64,62,65,40,66,41,67,91,68,93,69,123,70,125,71,139,-18,141,-18,142,-18,143,-18,144,-18,145,-18,147,-18,148,-18,150,-18,149,-18,163,-18,152,-18,154,-18,155,-18,151,-18,159,-18,153,-18,158,-18,156,-18,160,-18,157,-18,161,-18,162,-18,138,-18,131,-78,137,-78},new int[]{-28,53,-29,60});
    states[53] = new State(new int[]{131,55,137,59},new int[]{-2,54});
    states[54] = new State(-53);
    states[55] = new State(new int[]{133,56,135,57,44,-57,59,-57,58,-57,60,-57,62,-57,40,-57,41,-57,91,-57,93,-57,123,-57,125,-57,131,-57,137,-57,139,-57,141,-57,142,-57,143,-57,144,-57,145,-57,147,-57,148,-57,150,-57,149,-57,163,-57,152,-57,154,-57,155,-57,151,-57,159,-57,153,-57,158,-57,156,-57,160,-57,157,-57,161,-57,162,-57,138,-57});
    states[56] = new State(-55);
    states[57] = new State(new int[]{133,58,44,-58,59,-58,58,-58,60,-58,62,-58,40,-58,41,-58,91,-58,93,-58,123,-58,125,-58,131,-58,137,-58,139,-58,141,-58,142,-58,143,-58,144,-58,145,-58,147,-58,148,-58,150,-58,149,-58,163,-58,152,-58,154,-58,155,-58,151,-58,159,-58,153,-58,158,-58,156,-58,160,-58,157,-58,161,-58,162,-58,138,-58});
    states[58] = new State(-56);
    states[59] = new State(-59);
    states[60] = new State(-54);
    states[61] = new State(-77);
    states[62] = new State(-81);
    states[63] = new State(-82);
    states[64] = new State(-83);
    states[65] = new State(-84);
    states[66] = new State(-85);
    states[67] = new State(-86);
    states[68] = new State(-87);
    states[69] = new State(-88);
    states[70] = new State(-89);
    states[71] = new State(-90);
    states[72] = new State(-52);
    states[73] = new State(-48);
    states[74] = new State(new int[]{131,75,127,77});
    states[75] = new State(new int[]{62,76});
    states[76] = new State(-50);
    states[77] = new State(new int[]{62,78});
    states[78] = new State(-51);
    states[79] = new State(new int[]{60,74},new int[]{-21,80});
    states[80] = new State(new int[]{131,84,132,85},new int[]{-3,81,-22,87});
    states[81] = new State(new int[]{44,61,59,62,58,63,60,64,62,65,40,66,41,67,91,68,93,69,123,70,125,71,139,-19,141,-19,142,-19,143,-19,144,-19,145,-19,147,-19,148,-19,150,-19,149,-19,163,-19,152,-19,154,-19,155,-19,151,-19,159,-19,153,-19,158,-19,156,-19,160,-19,157,-19,161,-19,162,-19,138,-19,131,-78,132,-78},new int[]{-28,82,-29,86});
    states[82] = new State(new int[]{131,84,132,85},new int[]{-22,83});
    states[83] = new State(-61);
    states[84] = new State(-63);
    states[85] = new State(-64);
    states[86] = new State(-62);
    states[87] = new State(-60);
    states[88] = new State(new int[]{60,74,131,-49,137,-49},new int[]{-20,89,-21,73});
    states[89] = new State(new int[]{131,55,137,59},new int[]{-1,90,-2,72});
    states[90] = new State(new int[]{44,61,59,62,58,63,60,64,62,65,40,66,41,67,91,68,93,69,123,70,125,71,139,-20,141,-20,142,-20,143,-20,144,-20,145,-20,147,-20,148,-20,150,-20,149,-20,163,-20,152,-20,154,-20,155,-20,151,-20,159,-20,153,-20,158,-20,156,-20,160,-20,157,-20,161,-20,162,-20,138,-20,131,-78,137,-78},new int[]{-28,53,-29,60});
    states[91] = new State(new int[]{60,74,131,-49,137,-49},new int[]{-20,92,-21,73});
    states[92] = new State(new int[]{131,55,137,59},new int[]{-1,93,-2,72});
    states[93] = new State(new int[]{44,61,59,62,58,63,60,64,62,65,40,66,41,67,91,68,93,69,123,70,125,71,139,-21,141,-21,142,-21,143,-21,144,-21,145,-21,147,-21,148,-21,150,-21,149,-21,163,-21,152,-21,154,-21,155,-21,151,-21,159,-21,153,-21,158,-21,156,-21,160,-21,157,-21,161,-21,162,-21,138,-21,131,-78,137,-78},new int[]{-28,53,-29,60});
    states[94] = new State(new int[]{60,74,131,-49,137,-49},new int[]{-20,95,-21,73});
    states[95] = new State(new int[]{131,55,137,59},new int[]{-1,96,-2,72});
    states[96] = new State(new int[]{44,61,59,62,58,63,60,64,62,65,40,66,41,67,91,68,93,69,123,70,125,71,139,-22,141,-22,142,-22,143,-22,144,-22,145,-22,147,-22,148,-22,150,-22,149,-22,163,-22,152,-22,154,-22,155,-22,151,-22,159,-22,153,-22,158,-22,156,-22,160,-22,157,-22,161,-22,162,-22,138,-22,131,-78,137,-78},new int[]{-28,53,-29,60});
    states[97] = new State(new int[]{131,84,132,85},new int[]{-22,98});
    states[98] = new State(-23);
    states[99] = new State(new int[]{131,125,123,-45},new int[]{-23,100});
    states[100] = new State(new int[]{123,102},new int[]{-24,101});
    states[101] = new State(-24);
    states[102] = new State(new int[]{131,120,127,124},new int[]{-31,103,-32,123,-33,106,-27,122,-25,110});
    states[103] = new State(new int[]{125,104,131,120},new int[]{-32,105,-33,106,-27,122,-25,110});
    states[104] = new State(-70);
    states[105] = new State(-72);
    states[106] = new State(new int[]{131,107},new int[]{-27,109,-25,110});
    states[107] = new State(new int[]{59,108,91,-47,46,-47,60,-47,131,-47});
    states[108] = new State(-74);
    states[109] = new State(-76);
    states[110] = new State(new int[]{91,111,46,113,60,115,131,-67,62,-67,44,-67,139,-67,141,-67,142,-67,143,-67,144,-67,145,-67,147,-67,148,-67,150,-67,149,-67,163,-67,152,-67,154,-67,155,-67,151,-67,159,-67,153,-67,158,-67,156,-67,160,-67,157,-67,161,-67,162,-67,138,-67});
    states[111] = new State(new int[]{93,112});
    states[112] = new State(-65);
    states[113] = new State(new int[]{131,114});
    states[114] = new State(-46);
    states[115] = new State(new int[]{131,120},new int[]{-30,116,-27,121,-25,110});
    states[116] = new State(new int[]{62,117,44,118});
    states[117] = new State(-66);
    states[118] = new State(new int[]{131,120},new int[]{-27,119,-25,110});
    states[119] = new State(-69);
    states[120] = new State(-47);
    states[121] = new State(-68);
    states[122] = new State(-75);
    states[123] = new State(-71);
    states[124] = new State(-73);
    states[125] = new State(-44);
    states[126] = new State(-25);
    states[127] = new State(-26);
    states[128] = new State(-27);
    states[129] = new State(-28);
    states[130] = new State(-29);
    states[131] = new State(new int[]{61,132});
    states[132] = new State(new int[]{134,133,135,134,136,135});
    states[133] = new State(-30);
    states[134] = new State(-31);
    states[135] = new State(-32);
    states[136] = new State(new int[]{131,120},new int[]{-25,137});
    states[137] = new State(new int[]{46,113,139,-33,141,-33,142,-33,143,-33,144,-33,145,-33,147,-33,148,-33,150,-33,149,-33,163,-33,152,-33,154,-33,155,-33,151,-33,159,-33,153,-33,158,-33,156,-33,160,-33,157,-33,161,-33,162,-33,138,-33});
    states[138] = new State(new int[]{131,120},new int[]{-25,139});
    states[139] = new State(new int[]{46,113,59,141,139,-80,141,-80,142,-80,143,-80,144,-80,145,-80,147,-80,148,-80,150,-80,149,-80,163,-80,152,-80,154,-80,155,-80,151,-80,159,-80,153,-80,158,-80,156,-80,160,-80,157,-80,161,-80,162,-80,138,-80},new int[]{-26,140});
    states[140] = new State(-34);
    states[141] = new State(-79);
    states[142] = new State(new int[]{61,143});
    states[143] = new State(new int[]{134,144,135,145,136,146});
    states[144] = new State(-35);
    states[145] = new State(-36);
    states[146] = new State(-37);
    states[147] = new State(new int[]{131,148});
    states[148] = new State(-38);
    states[149] = new State(new int[]{131,150});
    states[150] = new State(-39);
    states[151] = new State(new int[]{131,152});
    states[152] = new State(-40);
    states[153] = new State(new int[]{131,154});
    states[154] = new State(-41);
    states[155] = new State(new int[]{131,120},new int[]{-27,156,-25,110});
    states[156] = new State(-42);
    states[157] = new State(new int[]{131,120},new int[]{-27,158,-25,110});
    states[158] = new State(-43);
    states[159] = new State(-14);
    states[160] = new State(new int[]{139,46,141,50,142,79,143,88,144,91,145,94,147,97,148,99,150,126,149,127,163,128,152,129,154,130,155,131,151,136,159,138,153,142,158,147,156,149,160,151,157,153,161,155,162,157,138,-12,128,-3},new int[]{-18,161,-19,49});
    states[161] = new State(-15);

    for (int sNo = 0; sNo < states.Length; sNo++) states[sNo].number = sNo;

    rules[1] = new Rule(-11, new int[]{-10,128});
    rules[2] = new Rule(-10, new int[]{-12,-13,-14,-15});
    rules[3] = new Rule(-10, new int[]{127});
    rules[4] = new Rule(-13, new int[]{138});
    rules[5] = new Rule(-15, new int[]{138,-16});
    rules[6] = new Rule(-15, new int[]{});
    rules[7] = new Rule(-16, new int[]{129,130});
    rules[8] = new Rule(-16, new int[]{});
    rules[9] = new Rule(-16, new int[]{129,127});
    rules[10] = new Rule(-12, new int[]{-17});
    rules[11] = new Rule(-12, new int[]{});
    rules[12] = new Rule(-12, new int[]{127});
    rules[13] = new Rule(-17, new int[]{-17,-18});
    rules[14] = new Rule(-17, new int[]{-18});
    rules[15] = new Rule(-17, new int[]{127,-18});
    rules[16] = new Rule(-18, new int[]{139,-16,140});
    rules[17] = new Rule(-18, new int[]{-19});
    rules[18] = new Rule(-19, new int[]{141,-20,-1});
    rules[19] = new Rule(-19, new int[]{142,-21,-3});
    rules[20] = new Rule(-19, new int[]{143,-20,-1});
    rules[21] = new Rule(-19, new int[]{144,-20,-1});
    rules[22] = new Rule(-19, new int[]{145,-20,-1});
    rules[23] = new Rule(-19, new int[]{147,-22});
    rules[24] = new Rule(-19, new int[]{148,-23,-24});
    rules[25] = new Rule(-19, new int[]{150});
    rules[26] = new Rule(-19, new int[]{149});
    rules[27] = new Rule(-19, new int[]{163});
    rules[28] = new Rule(-19, new int[]{152});
    rules[29] = new Rule(-19, new int[]{154});
    rules[30] = new Rule(-19, new int[]{155,61,134});
    rules[31] = new Rule(-19, new int[]{155,61,135});
    rules[32] = new Rule(-19, new int[]{155,61,136});
    rules[33] = new Rule(-19, new int[]{151,-25});
    rules[34] = new Rule(-19, new int[]{159,-25,-26});
    rules[35] = new Rule(-19, new int[]{153,61,134});
    rules[36] = new Rule(-19, new int[]{153,61,135});
    rules[37] = new Rule(-19, new int[]{153,61,136});
    rules[38] = new Rule(-19, new int[]{158,131});
    rules[39] = new Rule(-19, new int[]{156,131});
    rules[40] = new Rule(-19, new int[]{160,131});
    rules[41] = new Rule(-19, new int[]{157,131});
    rules[42] = new Rule(-19, new int[]{161,-27});
    rules[43] = new Rule(-19, new int[]{162,-27});
    rules[44] = new Rule(-23, new int[]{131});
    rules[45] = new Rule(-23, new int[]{});
    rules[46] = new Rule(-25, new int[]{-25,46,131});
    rules[47] = new Rule(-25, new int[]{131});
    rules[48] = new Rule(-20, new int[]{-21});
    rules[49] = new Rule(-20, new int[]{});
    rules[50] = new Rule(-21, new int[]{60,131,62});
    rules[51] = new Rule(-21, new int[]{60,127,62});
    rules[52] = new Rule(-1, new int[]{-2});
    rules[53] = new Rule(-1, new int[]{-1,-28,-2});
    rules[54] = new Rule(-1, new int[]{-1,-29});
    rules[55] = new Rule(-2, new int[]{131,133});
    rules[56] = new Rule(-2, new int[]{131,135,133});
    rules[57] = new Rule(-2, new int[]{131});
    rules[58] = new Rule(-2, new int[]{131,135});
    rules[59] = new Rule(-2, new int[]{137});
    rules[60] = new Rule(-3, new int[]{-22});
    rules[61] = new Rule(-3, new int[]{-3,-28,-22});
    rules[62] = new Rule(-3, new int[]{-3,-29});
    rules[63] = new Rule(-22, new int[]{131});
    rules[64] = new Rule(-22, new int[]{132});
    rules[65] = new Rule(-27, new int[]{-25,91,93});
    rules[66] = new Rule(-27, new int[]{-25,60,-30,62});
    rules[67] = new Rule(-27, new int[]{-25});
    rules[68] = new Rule(-30, new int[]{-27});
    rules[69] = new Rule(-30, new int[]{-30,44,-27});
    rules[70] = new Rule(-24, new int[]{123,-31,125});
    rules[71] = new Rule(-31, new int[]{-32});
    rules[72] = new Rule(-31, new int[]{-31,-32});
    rules[73] = new Rule(-31, new int[]{127});
    rules[74] = new Rule(-32, new int[]{-33,131,59});
    rules[75] = new Rule(-33, new int[]{-27});
    rules[76] = new Rule(-33, new int[]{-33,-27});
    rules[77] = new Rule(-28, new int[]{44});
    rules[78] = new Rule(-28, new int[]{});
    rules[79] = new Rule(-26, new int[]{59});
    rules[80] = new Rule(-26, new int[]{});
    rules[81] = new Rule(-29, new int[]{59});
    rules[82] = new Rule(-29, new int[]{58});
    rules[83] = new Rule(-29, new int[]{60});
    rules[84] = new Rule(-29, new int[]{62});
    rules[85] = new Rule(-29, new int[]{40});
    rules[86] = new Rule(-29, new int[]{41});
    rules[87] = new Rule(-29, new int[]{91});
    rules[88] = new Rule(-29, new int[]{93});
    rules[89] = new Rule(-29, new int[]{123});
    rules[90] = new Rule(-29, new int[]{125});
    rules[91] = new Rule(-14, new int[]{-14,-34});
    rules[92] = new Rule(-14, new int[]{-34});
    rules[93] = new Rule(-14, new int[]{127});
    rules[94] = new Rule(-34, new int[]{-35,-6,-36,59});
    rules[95] = new Rule(-35, new int[]{132,58});
    rules[96] = new Rule(-36, new int[]{});
    rules[97] = new Rule(-36, new int[]{-36,124,-6});
    rules[98] = new Rule(-6, new int[]{});
    rules[99] = new Rule(-6, new int[]{-7});
    rules[100] = new Rule(-7, new int[]{-4});
    rules[101] = new Rule(-7, new int[]{-9,-5});
    rules[102] = new Rule(-7, new int[]{-7,-9,-5});
    rules[103] = new Rule(-5, new int[]{});
    rules[104] = new Rule(-5, new int[]{-4});
    rules[105] = new Rule(-4, new int[]{-37});
    rules[106] = new Rule(-4, new int[]{-4,-37});
    rules[107] = new Rule(-37, new int[]{131});
    rules[108] = new Rule(-37, new int[]{137});
    rules[109] = new Rule(-37, new int[]{135});
    rules[110] = new Rule(-9, new int[]{-8});
    rules[111] = new Rule(-9, new int[]{146,131,-8});
    rules[112] = new Rule(-9, new int[]{146,131});
    rules[113] = new Rule(-8, new int[]{123,-16,125});
    rules[114] = new Rule(-8, new int[]{123,-16,127});

    aliases = new Dictionary<int, string>();
    aliases.Add(138, "%%");
    aliases.Add(139, "%{");
    aliases.Add(140, "%}");
    aliases.Add(141, "%token");
    aliases.Add(142, "%type");
    aliases.Add(143, "%left");
    aliases.Add(144, "%right");
    aliases.Add(145, "%nonassoc");
    aliases.Add(146, "%prec");
    aliases.Add(147, "%start");
    aliases.Add(148, "%union");
    aliases.Add(149, "%defines");
    aliases.Add(150, "%locations");
    aliases.Add(151, "%namespace");
    aliases.Add(152, "%partial");
    aliases.Add(153, "%output");
    aliases.Add(154, "%sharetokens");
    aliases.Add(155, "%importtokens");
    aliases.Add(156, "%parsertype");
    aliases.Add(157, "%tokentype");
    aliases.Add(158, "%scanbasetype");
    aliases.Add(159, "%using");
    aliases.Add(160, "%visibility");
    aliases.Add(161, "%YYSTYPE");
    aliases.Add(162, "%YYLTYPE");
    aliases.Add(163, "%cstokenfile");
  }

  protected override void Initialize() {
    this.InitSpecialTokens((int)Token.error, (int)Token.EOF);
    this.InitStates(states);
    this.InitRules(rules);
    this.InitNonTerminals(nonTerms);
  }

  protected override void DoAction(int action)
  {
#pragma warning disable 162, 1522
    switch (action)
    {
      case 4: // Divider -> "%%"
{ TidyUpDefinitions(LocationStack[LocationStack.Depth-1]); }
        break;
      case 5: // EpilogOpt -> "%%", CodeBlock
{ grammar.epilogCode = LocationStack[LocationStack.Depth-1]; }
        break;
      case 7: // CodeBlock -> codeStart, codeEnd
{ /* default location action @$ = @1.Merge(@2); */ }
        break;
      case 9: // CodeBlock -> codeStart, error
{ handler.ListError(LocationStack[LocationStack.Depth-2], 77); }
        break;
      case 16: // Definition -> "%{", CodeBlock, "%}"
{ grammar.prologCode.Add(LocationStack[LocationStack.Depth-2]); }
        break;
      case 18: // Declaration -> "%token", KindOpt, TokenList
{ DeclareTokens(LocationStack[LocationStack.Depth-3], PrecType.token, LocationStack[LocationStack.Depth-2].ToString(), ValueStack[ValueStack.Depth-1].tokenList); }
        break;
      case 19: // Declaration -> "%type", Kind, NtSymbolList
{
						  string kind = LocationStack[LocationStack.Depth-2].ToString();
						  DeclareNtKind(kind, ValueStack[ValueStack.Depth-1].stringList);
						}
        break;
      case 20: // Declaration -> "%left", KindOpt, TokenList
{ DeclareTokens(LocationStack[LocationStack.Depth-3], PrecType.left, LocationStack[LocationStack.Depth-2].ToString(), ValueStack[ValueStack.Depth-1].tokenList); }
        break;
      case 21: // Declaration -> "%right", KindOpt, TokenList
{ DeclareTokens(LocationStack[LocationStack.Depth-3], PrecType.right, LocationStack[LocationStack.Depth-2].ToString(), ValueStack[ValueStack.Depth-1].tokenList); }
        break;
      case 22: // Declaration -> "%nonassoc", KindOpt, TokenList
{ DeclareTokens(LocationStack[LocationStack.Depth-3], PrecType.nonassoc, LocationStack[LocationStack.Depth-2].ToString(), ValueStack[ValueStack.Depth-1].tokenList); }
        break;
      case 23: // Declaration -> "%start", NtSymbol
{ grammar.startSymbol = grammar.LookupNonTerminal(LocationStack[LocationStack.Depth-1].ToString()); }
        break;
      case 24: // Declaration -> "%union", TypeNameOpt, UnionTypeConstructor
{ grammar.unionType = LocationStack[LocationStack.Depth-1]; }
        break;
      case 25: // Declaration -> "%locations"
{ handler.ListError(LocationStack[LocationStack.Depth-1], 101); }
        break;
      case 26: // Declaration -> "%defines"
{ GPCG.Defines = true; }
        break;
      case 27: // Declaration -> "%cstokenfile"
{ GPCG.CsTokenFile = true; }
        break;
      case 28: // Declaration -> "%partial"
{ grammar.IsPartial = true; }
        break;
      case 29: // Declaration -> "%sharetokens"
{ GPCG.ShareTokens = true; }
        break;
      case 30: // Declaration -> "%importtokens", '=', filePath
{ GPCG.ImportedTokens = true;
						  grammar.DatFileName = LocationStack[LocationStack.Depth-1].ToString(); }
        break;
      case 31: // Declaration -> "%importtokens", '=', litstring
{ GPCG.ImportedTokens = true;
						  grammar.DatFileName = GetLitString(LocationStack[LocationStack.Depth-1]); }
        break;
      case 32: // Declaration -> "%importtokens", '=', verbatim
{ GPCG.ImportedTokens = true;
						  grammar.DatFileName = GetVerbatimString(LocationStack[LocationStack.Depth-1]); }
        break;
      case 33: // Declaration -> "%namespace", DottedName
{ grammar.Namespace = LocationStack[LocationStack.Depth-1].ToString(); }
        break;
      case 34: // Declaration -> "%using", DottedName, SemiOpt
{ grammar.usingList.Add(LocationStack[LocationStack.Depth-2].ToString()); }
        break;
      case 35: // Declaration -> "%output", '=', filePath
{ grammar.OutFileName = LocationStack[LocationStack.Depth-1].ToString(); }
        break;
      case 36: // Declaration -> "%output", '=', litstring
{ grammar.OutFileName = GetLitString(LocationStack[LocationStack.Depth-1]); }
        break;
      case 37: // Declaration -> "%output", '=', verbatim
{ grammar.OutFileName = GetVerbatimString(LocationStack[LocationStack.Depth-1]); }
        break;
      case 38: // Declaration -> "%scanbasetype", ident
{ grammar.ScanBaseName = LocationStack[LocationStack.Depth-1].ToString(); }
        break;
      case 39: // Declaration -> "%parsertype", ident
{ grammar.ParserName = LocationStack[LocationStack.Depth-1].ToString(); }
        break;
      case 40: // Declaration -> "%visibility", ident
{ grammar.Visibility = LocationStack[LocationStack.Depth-1].ToString(); }
        break;
      case 41: // Declaration -> "%tokentype", ident
{ grammar.TokenName = LocationStack[LocationStack.Depth-1].ToString(); }
        break;
      case 42: // Declaration -> "%YYSTYPE", TypeConstructor
{ SetSemanticType(LocationStack[LocationStack.Depth-1]); }
        break;
      case 43: // Declaration -> "%YYLTYPE", TypeConstructor
{ grammar.LocationTypeName = LocationStack[LocationStack.Depth-1].ToString(); }
        break;
      case 44: // TypeNameOpt -> ident
{ SetSemanticType(LocationStack[LocationStack.Depth-1]); }
        break;
      case 50: // Kind -> '<', ident, '>'
{ CurrentLocationSpan = LocationStack[LocationStack.Depth-2]; }
        break;
      case 52: // TokenList -> TokenDecl
{
                          CurrentSemanticValue.tokenList = new List<TokenInfo>();
                          CurrentSemanticValue.tokenList.Add(ValueStack[ValueStack.Depth-1].tokenInfo);
                        }
        break;
      case 53: // TokenList -> TokenList, CommaOpt, TokenDecl
{ ValueStack[ValueStack.Depth-3].tokenList.Add(ValueStack[ValueStack.Depth-1].tokenInfo); CurrentSemanticValue.tokenList = ValueStack[ValueStack.Depth-3].tokenList;}
        break;
      case 54: // TokenList -> TokenList, BadSeparator
{ handler.ListError(LocationStack[LocationStack.Depth-1], 75); CurrentSemanticValue.tokenList = ValueStack[ValueStack.Depth-2].tokenList; }
        break;
      case 55: // TokenDecl -> ident, number
{ 
                          handler.ListError(LocationStack[LocationStack.Depth-1], 100); 
                          CurrentSemanticValue.tokenInfo = new TokenInfo(LocationStack[LocationStack.Depth-2], null);
                        }
        break;
      case 56: // TokenDecl -> ident, litstring, number
{ 
                          handler.ListError(LocationStack[LocationStack.Depth-2], 100); 
                          CurrentSemanticValue.tokenInfo = new TokenInfo(LocationStack[LocationStack.Depth-3], LocationStack[LocationStack.Depth-2]);
                        }
        break;
      case 57: // TokenDecl -> ident
{ CurrentSemanticValue.tokenInfo = new TokenInfo(LocationStack[LocationStack.Depth-1], null); }
        break;
      case 58: // TokenDecl -> ident, litstring
{ CurrentSemanticValue.tokenInfo = new TokenInfo(LocationStack[LocationStack.Depth-2], LocationStack[LocationStack.Depth-1]); }
        break;
      case 59: // TokenDecl -> litchar
{ CurrentSemanticValue.tokenInfo = new TokenInfo(LocationStack[LocationStack.Depth-1], null); }
        break;
      case 60: // NtSymbolList -> NtSymbol
{ 
                          CurrentSemanticValue.stringList = new List<string>();
						  CurrentSemanticValue.stringList.Add(LocationStack[LocationStack.Depth-1].ToString()); 
						}
        break;
      case 61: // NtSymbolList -> NtSymbolList, CommaOpt, NtSymbol
{ ValueStack[ValueStack.Depth-3].stringList.Add(LocationStack[LocationStack.Depth-1].ToString()); CurrentSemanticValue.stringList = ValueStack[ValueStack.Depth-3].stringList; }
        break;
      case 62: // NtSymbolList -> NtSymbolList, BadSeparator
{ handler.ListError(LocationStack[LocationStack.Depth-1], 75); CurrentSemanticValue.stringList = ValueStack[ValueStack.Depth-2].stringList; }
        break;
      case 94: // ARule -> RuleProlog, RightHandSide, AlternativesOpt, ';'
{ ClearCurrentLHS(); }
        break;
      case 95: // RuleProlog -> anchoredSymbol, ':'
{ SetCurrentLHS(LocationStack[LocationStack.Depth-2]); }
        break;
      case 98: // RightHandSide -> /* empty */
{ CurrentSemanticValue.prod = NewProduction(); FinalizeProduction(CurrentSemanticValue.prod); }
        break;
      case 99: // RightHandSide -> RHStermList
{ CurrentSemanticValue.prod = ValueStack[ValueStack.Depth-1].prod; FinalizeProduction(CurrentSemanticValue.prod); }
        break;
      case 100: // RHStermList -> Symbols
{ CurrentSemanticValue.prod = NewProduction(ValueStack[ValueStack.Depth-1].stringList, null); }
        break;
      case 101: // RHStermList -> PrecOptAndAction, SymbolsOpt
{
                          CurrentSemanticValue.prod = NewProduction(null, ValueStack[ValueStack.Depth-2].proxy);
                          AddSymbolsToProduction(CurrentSemanticValue.prod, ValueStack[ValueStack.Depth-1].stringList);
                        }
        break;
      case 102: // RHStermList -> RHStermList, PrecOptAndAction, SymbolsOpt
{
                          AddActionToProduction(ValueStack[ValueStack.Depth-3].prod, ValueStack[ValueStack.Depth-2].proxy);
                          AddSymbolsToProduction(ValueStack[ValueStack.Depth-3].prod, ValueStack[ValueStack.Depth-1].stringList);
                          CurrentSemanticValue.prod = ValueStack[ValueStack.Depth-3].prod;
                        }
        break;
      case 103: // SymbolsOpt -> /* empty */
{ CurrentSemanticValue.stringList = null; }
        break;
      case 105: // Symbols -> SymOrLit
{ CurrentSemanticValue.stringList = new List<string>(); CurrentSemanticValue.stringList.Add(LocationStack[LocationStack.Depth-1].ToString()); }
        break;
      case 106: // Symbols -> Symbols, SymOrLit
{ ValueStack[ValueStack.Depth-2].stringList.Add(LocationStack[LocationStack.Depth-1].ToString());  CurrentSemanticValue.stringList = ValueStack[ValueStack.Depth-2].stringList; }
        break;
      case 110: // PrecOptAndAction -> Action
{ CurrentSemanticValue.proxy = ValueStack[ValueStack.Depth-1].proxy; }
        break;
      case 111: // PrecOptAndAction -> "%prec", ident, Action
{ ValueStack[ValueStack.Depth-1].proxy.precedenceToken = LocationStack[LocationStack.Depth-2]; ValueStack[ValueStack.Depth-1].proxy.precedenceSpan = LocationStack[LocationStack.Depth-3]; CurrentSemanticValue.proxy = ValueStack[ValueStack.Depth-1].proxy; }
        break;
      case 112: // PrecOptAndAction -> "%prec", ident
{ CurrentSemanticValue.proxy = new ActionProxy(LocationStack[LocationStack.Depth-2], LocationStack[LocationStack.Depth-1], null); }
        break;
      case 113: // Action -> '{', CodeBlock, '}'
{ CurrentSemanticValue.proxy = new ActionProxy(null, null, CurrentLocationSpan); }
        break;
    }
#pragma warning restore 162, 1522
  }

  protected override string TerminalToString(int terminal)
  {
    if (aliases != null && aliases.ContainsKey(terminal))
        return aliases[terminal];
    else if (((Token)terminal).ToString() != terminal.ToString(CultureInfo.InvariantCulture))
        return ((Token)terminal).ToString();
    else
        return CharToString((char)terminal);
  }

}
}
