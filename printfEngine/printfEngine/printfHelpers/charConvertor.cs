using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace printfEngine.printfHelpers
{
    class charConvertor
    {
        public static Rectangle space = new Rectangle(0 * monogameClass.fontSize.X, 0 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle face = new Rectangle(1 * monogameClass.fontSize.X, 0 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle face2 = new Rectangle(2 * monogameClass.fontSize.X, 0 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle heart = new Rectangle(3 * monogameClass.fontSize.X, 0 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle diamond = new Rectangle(4 * monogameClass.fontSize.X, 0 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle club = new Rectangle(5 * monogameClass.fontSize.X, 0 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle spade = new Rectangle(6 * monogameClass.fontSize.X, 0 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle circle = new Rectangle(7 * monogameClass.fontSize.X, 0 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle circleHole = new Rectangle(8 * monogameClass.fontSize.X, 0 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle circleDot = new Rectangle(9 * monogameClass.fontSize.X, 0 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle dotHole = new Rectangle(10 * monogameClass.fontSize.X, 0 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle mars = new Rectangle(11 * monogameClass.fontSize.X, 0 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle venus = new Rectangle(12 * monogameClass.fontSize.X, 0 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle quaver = new Rectangle(13 * monogameClass.fontSize.X, 0 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle beamedQuaver = new Rectangle(14 * monogameClass.fontSize.X, 0 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle sun = new Rectangle(15 * monogameClass.fontSize.X, 0 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);

        public static Rectangle rTriangle = new Rectangle(0 * monogameClass.fontSize.X, 1 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle lTriangle = new Rectangle(1 * monogameClass.fontSize.X, 1 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle upDown = new Rectangle(2 * monogameClass.fontSize.X, 1 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle tripleExclamation = new Rectangle(3 * monogameClass.fontSize.X, 1 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle pilcrow = new Rectangle(4 * monogameClass.fontSize.X, 1 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle section = new Rectangle(5 * monogameClass.fontSize.X, 1 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle cursor = new Rectangle(6 * monogameClass.fontSize.X, 1 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle upDownBar = new Rectangle(7 * monogameClass.fontSize.X, 1 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle upArrow = new Rectangle(8 * monogameClass.fontSize.X, 1 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle downArrow = new Rectangle(9 * monogameClass.fontSize.X, 1 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle rightArrow = new Rectangle(10 * monogameClass.fontSize.X, 1 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle leftArrow = new Rectangle(11 * monogameClass.fontSize.X, 1 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle rightAngle = new Rectangle(12 * monogameClass.fontSize.X, 1 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle leftRight = new Rectangle(13 * monogameClass.fontSize.X, 1 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle upTriangle = new Rectangle(14 * monogameClass.fontSize.X, 1 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle downTriangle = new Rectangle(15 * monogameClass.fontSize.X, 1 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);

        public static Rectangle empty = new Rectangle(0 * monogameClass.fontSize.X, 2 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle exclamation = new Rectangle(1 * monogameClass.fontSize.X, 2 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle quotation = new Rectangle(2 * monogameClass.fontSize.X, 2 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle hash = new Rectangle(3 * monogameClass.fontSize.X, 2 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle dollar = new Rectangle(4 * monogameClass.fontSize.X, 2 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle percent = new Rectangle(5 * monogameClass.fontSize.X, 2 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle ampersand = new Rectangle(6 * monogameClass.fontSize.X, 2 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle apostrophe = new Rectangle(7 * monogameClass.fontSize.X, 2 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle lBracket = new Rectangle(8 * monogameClass.fontSize.X, 2 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle rBracket = new Rectangle(9 * monogameClass.fontSize.X, 2 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle asterisk = new Rectangle(10 * monogameClass.fontSize.X, 2 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle plus = new Rectangle(11 * monogameClass.fontSize.X, 2 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle comma = new Rectangle(12 * monogameClass.fontSize.X, 2 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle dash = new Rectangle(13 * monogameClass.fontSize.X, 2 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle fullStop = new Rectangle(14 * monogameClass.fontSize.X, 2 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle slash = new Rectangle(15 * monogameClass.fontSize.X, 2 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);

        public static Rectangle zero = new Rectangle(0 * monogameClass.fontSize.X, 3 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle one = new Rectangle(1 * monogameClass.fontSize.X, 3 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle two = new Rectangle(2 * monogameClass.fontSize.X, 3 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle three = new Rectangle(3 * monogameClass.fontSize.X, 3 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle four = new Rectangle(4 * monogameClass.fontSize.X, 3 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle five = new Rectangle(5 * monogameClass.fontSize.X, 3 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle six = new Rectangle(6 * monogameClass.fontSize.X, 3 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle seven = new Rectangle(7 * monogameClass.fontSize.X, 3 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle eight = new Rectangle(8 * monogameClass.fontSize.X, 3 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle nine = new Rectangle(9 * monogameClass.fontSize.X, 3 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle colon = new Rectangle(10 * monogameClass.fontSize.X, 3 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle semicolon = new Rectangle(11 * monogameClass.fontSize.X, 3 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle lessThan = new Rectangle(12 * monogameClass.fontSize.X, 3 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle equals = new Rectangle(13 * monogameClass.fontSize.X, 3 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle greaterThan = new Rectangle(14 * monogameClass.fontSize.X, 3 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle questionMark = new Rectangle(15 * monogameClass.fontSize.X, 3 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);

        public static Rectangle at = new Rectangle(0 * monogameClass.fontSize.X, 4 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle A = new Rectangle(1 * monogameClass.fontSize.X, 4 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle B = new Rectangle(2 * monogameClass.fontSize.X, 4 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle C = new Rectangle(3 * monogameClass.fontSize.X, 4 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle D = new Rectangle(4 * monogameClass.fontSize.X, 4 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle E = new Rectangle(5 * monogameClass.fontSize.X, 4 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle F = new Rectangle(6 * monogameClass.fontSize.X, 4 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle G = new Rectangle(7 * monogameClass.fontSize.X, 4 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle H = new Rectangle(8 * monogameClass.fontSize.X, 4 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle I = new Rectangle(9 * monogameClass.fontSize.X, 4 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle J = new Rectangle(10 * monogameClass.fontSize.X, 4 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle K = new Rectangle(11 * monogameClass.fontSize.X, 4 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle L = new Rectangle(12 * monogameClass.fontSize.X, 4 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle M = new Rectangle(13 * monogameClass.fontSize.X, 4 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle N = new Rectangle(14 * monogameClass.fontSize.X, 4 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle O = new Rectangle(15 * monogameClass.fontSize.X, 4 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);

        public static Rectangle P = new Rectangle(0 * monogameClass.fontSize.X, 5 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle Q = new Rectangle(1 * monogameClass.fontSize.X, 5 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle R = new Rectangle(2 * monogameClass.fontSize.X, 5 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle S = new Rectangle(3 * monogameClass.fontSize.X, 5 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle T = new Rectangle(4 * monogameClass.fontSize.X, 5 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle U = new Rectangle(5 * monogameClass.fontSize.X, 5 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle V = new Rectangle(6 * monogameClass.fontSize.X, 5 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle W = new Rectangle(7 * monogameClass.fontSize.X, 5 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle X = new Rectangle(8 * monogameClass.fontSize.X, 5 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle Y = new Rectangle(9 * monogameClass.fontSize.X, 5 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle Z = new Rectangle(10 * monogameClass.fontSize.X, 5 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle lSquareBrace = new Rectangle(11 * monogameClass.fontSize.X, 5 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle backslash = new Rectangle(12 * monogameClass.fontSize.X, 5 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle rSquareBrace = new Rectangle(13 * monogameClass.fontSize.X, 5 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle caret = new Rectangle(14 * monogameClass.fontSize.X, 5 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle underscore = new Rectangle(15 * monogameClass.fontSize.X, 5 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);

        public static Rectangle accent = new Rectangle(0 * monogameClass.fontSize.X, 6 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle a = new Rectangle(1 * monogameClass.fontSize.X, 6 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle b = new Rectangle(2 * monogameClass.fontSize.X, 6 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle c = new Rectangle(3 * monogameClass.fontSize.X, 6 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle d = new Rectangle(4 * monogameClass.fontSize.X, 6 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle e = new Rectangle(5 * monogameClass.fontSize.X, 6 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle f = new Rectangle(6 * monogameClass.fontSize.X, 6 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle g = new Rectangle(7 * monogameClass.fontSize.X, 6 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle h = new Rectangle(8 * monogameClass.fontSize.X, 6 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle i = new Rectangle(9 * monogameClass.fontSize.X, 6 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle j = new Rectangle(10 * monogameClass.fontSize.X, 6 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle k = new Rectangle(11 * monogameClass.fontSize.X, 6 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle l = new Rectangle(12 * monogameClass.fontSize.X, 6 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle m = new Rectangle(13 * monogameClass.fontSize.X, 6 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle n = new Rectangle(14 * monogameClass.fontSize.X, 6 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle o = new Rectangle(15 * monogameClass.fontSize.X, 6 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);

        public static Rectangle p = new Rectangle(0 * monogameClass.fontSize.X, 7 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle q = new Rectangle(1 * monogameClass.fontSize.X, 7 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle r = new Rectangle(2 * monogameClass.fontSize.X, 7 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle s = new Rectangle(3 * monogameClass.fontSize.X, 7 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle t = new Rectangle(4 * monogameClass.fontSize.X, 7 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle u = new Rectangle(5 * monogameClass.fontSize.X, 7 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle v = new Rectangle(6 * monogameClass.fontSize.X, 7 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle w = new Rectangle(7 * monogameClass.fontSize.X, 7 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle x = new Rectangle(8 * monogameClass.fontSize.X, 7 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle y = new Rectangle(9 * monogameClass.fontSize.X, 7 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle z = new Rectangle(10 * monogameClass.fontSize.X, 7 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle lCurlyBrace = new Rectangle(11 * monogameClass.fontSize.X, 7 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle tallColon = new Rectangle(12 * monogameClass.fontSize.X, 7 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle rCurlyBrace = new Rectangle(13 * monogameClass.fontSize.X, 7 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle tilde = new Rectangle(14 * monogameClass.fontSize.X, 7 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle house = new Rectangle(15 * monogameClass.fontSize.X, 7 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);

        public static Rectangle upperCedilla = new Rectangle(0 * monogameClass.fontSize.X, 8 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle diaeresisU = new Rectangle(1 * monogameClass.fontSize.X, 8 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle acuteE = new Rectangle(2 * monogameClass.fontSize.X, 8 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle circumflexA = new Rectangle(3 * monogameClass.fontSize.X, 8 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle diaeresisA = new Rectangle(4 * monogameClass.fontSize.X, 8 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle graveA = new Rectangle(5 * monogameClass.fontSize.X, 8 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle ringA = new Rectangle(6 * monogameClass.fontSize.X, 8 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle lowerCedilla = new Rectangle(7 * monogameClass.fontSize.X, 8 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle circumflexE = new Rectangle(8 * monogameClass.fontSize.X, 8 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle diaeresisE = new Rectangle(9 * monogameClass.fontSize.X, 8 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle graveE = new Rectangle(10 * monogameClass.fontSize.X, 8 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle diaeresisI = new Rectangle(11 * monogameClass.fontSize.X, 8 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle circumflexI = new Rectangle(12 * monogameClass.fontSize.X, 8 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle graveI = new Rectangle(13 * monogameClass.fontSize.X, 8 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle upperDiaeresisA = new Rectangle(14 * monogameClass.fontSize.X, 8 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle upperRingA = new Rectangle(15 * monogameClass.fontSize.X, 8 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);

        public static Rectangle upperAcuteE = new Rectangle(0 * monogameClass.fontSize.X, 9 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle ae = new Rectangle(1 * monogameClass.fontSize.X, 9 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle AE = new Rectangle(2 * monogameClass.fontSize.X, 9 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle circumflexO = new Rectangle(3 * monogameClass.fontSize.X, 9 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle diaeresisO = new Rectangle(4 * monogameClass.fontSize.X, 9 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle graveO = new Rectangle(5 * monogameClass.fontSize.X, 9 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle circumflexU = new Rectangle(6 * monogameClass.fontSize.X, 9 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle graveU = new Rectangle(7 * monogameClass.fontSize.X, 9 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle diaeresisY = new Rectangle(8 * monogameClass.fontSize.X, 9 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle upperDiaeresisO = new Rectangle(9 * monogameClass.fontSize.X, 9 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle upperDiaeresisU = new Rectangle(10 * monogameClass.fontSize.X, 9 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle cent = new Rectangle(11 * monogameClass.fontSize.X, 9 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle pound = new Rectangle(12 * monogameClass.fontSize.X, 9 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle yen = new Rectangle(13 * monogameClass.fontSize.X, 9 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle ruble = new Rectangle(14 * monogameClass.fontSize.X, 9 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle florin = new Rectangle(15 * monogameClass.fontSize.X, 9 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);

        public static Rectangle acuteA = new Rectangle(0 * monogameClass.fontSize.X, 10 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle acuteI = new Rectangle(1 * monogameClass.fontSize.X, 10 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle acuteO = new Rectangle(2 * monogameClass.fontSize.X, 10 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle acuteU = new Rectangle(3 * monogameClass.fontSize.X, 10 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle tildeN = new Rectangle(4 * monogameClass.fontSize.X, 10 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle upperTildeN = new Rectangle(5 * monogameClass.fontSize.X, 10 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle femenineA = new Rectangle(6 * monogameClass.fontSize.X, 10 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle masculineO = new Rectangle(7 * monogameClass.fontSize.X, 10 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle upsideDownQuestionMark = new Rectangle(8 * monogameClass.fontSize.X, 10 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle logicalNegateL = new Rectangle(9 * monogameClass.fontSize.X, 10 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle logicalNegateR = new Rectangle(10 * monogameClass.fontSize.X, 10 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle oneOverTwo = new Rectangle(11 * monogameClass.fontSize.X, 10 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle oneOverFour = new Rectangle(12 * monogameClass.fontSize.X, 10 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle upsideDownExclamation = new Rectangle(13 * monogameClass.fontSize.X, 10 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle doubleLeft = new Rectangle(14 * monogameClass.fontSize.X, 10 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle doubleRight = new Rectangle(15 * monogameClass.fontSize.X, 10 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);

        public static Rectangle ditherLight = new Rectangle(0 * monogameClass.fontSize.X, 11 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle ditherMedium = new Rectangle(1 * monogameClass.fontSize.X, 11 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle ditherHard = new Rectangle(2 * monogameClass.fontSize.X, 11 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle vertical = new Rectangle(3 * monogameClass.fontSize.X, 11 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle vertLeft = new Rectangle(4 * monogameClass.fontSize.X, 11 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle vertDoubleLeft = new Rectangle(5 * monogameClass.fontSize.X, 11 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle doubleVertLeft = new Rectangle(6 * monogameClass.fontSize.X, 11 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle leftDoubleDown = new Rectangle(7 * monogameClass.fontSize.X, 11 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle doubleLeftDown = new Rectangle(8 * monogameClass.fontSize.X, 11 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle doubleVertDoubleLeft = new Rectangle(9 * monogameClass.fontSize.X, 11 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle doubleVert = new Rectangle(10 * monogameClass.fontSize.X, 11 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle doubleLeftDoubleDown = new Rectangle(11 * monogameClass.fontSize.X, 11 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle doubleLeftDoubleUp = new Rectangle(12 * monogameClass.fontSize.X, 11 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle leftDoubleUp = new Rectangle(13 * monogameClass.fontSize.X, 11 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle doubleLeftUp = new Rectangle(14 * monogameClass.fontSize.X, 11 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle leftDown = new Rectangle(15 * monogameClass.fontSize.X, 11 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);

        public static Rectangle upRight = new Rectangle(0 * monogameClass.fontSize.Y, 12 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle horizUp = new Rectangle(1 * monogameClass.fontSize.Y, 12 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle horizDown = new Rectangle(2 * monogameClass.fontSize.Y, 12 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle vertRight = new Rectangle(3 * monogameClass.fontSize.Y, 12 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle horiz = new Rectangle(4 * monogameClass.fontSize.Y, 12 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle vertHoriz = new Rectangle(5 * monogameClass.fontSize.Y, 12 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle vertDoubleRight = new Rectangle(6 * monogameClass.fontSize.Y, 12 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle doubleVertRight = new Rectangle(7 * monogameClass.fontSize.Y, 12 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle doubleUpDoubleRight = new Rectangle(8 * monogameClass.fontSize.Y, 12 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle doubleDownDoubleRight = new Rectangle(9 * monogameClass.fontSize.Y, 12 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle doubleHorizDoubleUp = new Rectangle(10 * monogameClass.fontSize.Y, 12 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle doubleHorizDoubleDown = new Rectangle(11 * monogameClass.fontSize.Y, 12 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle doubleVertDoubleRight = new Rectangle(12 * monogameClass.fontSize.Y, 12 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle doubleHoriz = new Rectangle(13 * monogameClass.fontSize.Y, 12 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle doubleVertDoubleHoriz = new Rectangle(14 * monogameClass.fontSize.Y, 12 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle doubleHorizUp = new Rectangle(15 * monogameClass.fontSize.Y, 12 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);

        public static Rectangle horizDoubleUp = new Rectangle(0 * monogameClass.fontSize.X, 13 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle doubleHorizDown = new Rectangle(1 * monogameClass.fontSize.X, 13 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle horizDoubleDown = new Rectangle(2 * monogameClass.fontSize.X, 13 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle DoubleUpRight = new Rectangle(3 * monogameClass.fontSize.X, 13 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle upDoubleRight = new Rectangle(4 * monogameClass.fontSize.X, 13 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle doubleDownRight = new Rectangle(5 * monogameClass.fontSize.X, 13 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle downDoubleRight = new Rectangle(6 * monogameClass.fontSize.X, 13 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle horizDoubleVert = new Rectangle(7 * monogameClass.fontSize.X, 13 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle vertDoubleHoriz = new Rectangle(8 * monogameClass.fontSize.X, 13 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle leftUp = new Rectangle(9 * monogameClass.fontSize.X, 13 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle downRight = new Rectangle(10 * monogameClass.fontSize.X, 13 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle square = new Rectangle(11 * monogameClass.fontSize.X, 13 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle bottomHalfSquare = new Rectangle(12 * monogameClass.fontSize.X, 13 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle leftHalfSquare = new Rectangle(13 * monogameClass.fontSize.X, 13 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle rightHalfSquare = new Rectangle(14 * monogameClass.fontSize.X, 13 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle topHalfSquare = new Rectangle(15 * monogameClass.fontSize.X, 13 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);

        public static Rectangle alpha = new Rectangle(0 * monogameClass.fontSize.X, 14 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle ezset = new Rectangle(1 * monogameClass.fontSize.X, 14 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle gamma = new Rectangle(2 * monogameClass.fontSize.X, 14 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle pi = new Rectangle(3 * monogameClass.fontSize.X, 14 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle upperSigma = new Rectangle(4 * monogameClass.fontSize.X, 14 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle sigma = new Rectangle(5 * monogameClass.fontSize.X, 14 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle mu = new Rectangle(6 * monogameClass.fontSize.X, 14 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle tau = new Rectangle(7 * monogameClass.fontSize.X, 14 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle upperPhi = new Rectangle(8 * monogameClass.fontSize.X, 14 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle theta = new Rectangle(9 * monogameClass.fontSize.X, 14 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle omega = new Rectangle(10 * monogameClass.fontSize.X, 14 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle delta = new Rectangle(11 * monogameClass.fontSize.X, 14 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle infiniti = new Rectangle(12 * monogameClass.fontSize.X, 14 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle phi = new Rectangle(13 * monogameClass.fontSize.X, 14 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle epsilon = new Rectangle(14 * monogameClass.fontSize.X, 14 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle intersection = new Rectangle(15 * monogameClass.fontSize.X, 14 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);

        public static Rectangle equivalent = new Rectangle(0 * monogameClass.fontSize.X, 15 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle plusminus = new Rectangle(1 * monogameClass.fontSize.X, 15 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle greatertOrEqual = new Rectangle(2 * monogameClass.fontSize.X, 15 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle lessOrEqual = new Rectangle(3 * monogameClass.fontSize.X, 15 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle ceil = new Rectangle(4 * monogameClass.fontSize.X, 15 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle floor = new Rectangle(5 * monogameClass.fontSize.X, 15 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle divide = new Rectangle(6 * monogameClass.fontSize.X, 15 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle approximate = new Rectangle(7 * monogameClass.fontSize.X, 15 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle degrees = new Rectangle(8 * monogameClass.fontSize.X, 15 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle bigDot = new Rectangle(9 * monogameClass.fontSize.X, 15 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle dot = new Rectangle(10 * monogameClass.fontSize.X, 15 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle squareRoot = new Rectangle(11 * monogameClass.fontSize.X, 15 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle superscript = new Rectangle(12 * monogameClass.fontSize.X, 15 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle squared = new Rectangle(13 * monogameClass.fontSize.X, 15 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle box = new Rectangle(14 * monogameClass.fontSize.X, 15 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        public static Rectangle anotherBlank = new Rectangle(15 * monogameClass.fontSize.X, 15 * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);

        public static List<Rectangle> charRect = new List<Rectangle>
        {
            space,face,face2,heart,diamond,club,spade,circle,
            circleHole,circleDot,dotHole,mars,venus,
            quaver,beamedQuaver,sun,rTriangle,lTriangle,
            upDown,tripleExclamation,pilcrow,section,cursor,
            upDownBar,upArrow,downArrow,rightArrow,leftArrow,
            rightAngle,leftRight,upTriangle,downTriangle,
            empty,exclamation,quotation,hash,dollar,
            percent,ampersand,apostrophe,lBracket,rBracket,
            asterisk,plus,comma,dash,fullStop,slash,zero,
            one,two,three,four,five,six,seven,eight,nine,
            colon,semicolon,lessThan,equals,greaterThan,
            questionMark,at,A,B,C,D,E,F,G,H,I,J,K,L,M,N,
            O,P,Q,R,S,T,U,V,W,X,Y,Z,lSquareBrace,backslash,
            rSquareBrace,caret,underscore,accent,
            a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,
            x,y,z,lCurlyBrace,tallColon,rCurlyBrace,tilde,
            house,upperCedilla,diaeresisU,acuteE,circumflexA,
            diaeresisA,graveA,ringA,lowerCedilla,circumflexE,
            diaeresisE,graveE,diaeresisI,circumflexI,graveI,
            upperDiaeresisA,upperRingA,upperAcuteE,ae,AE,
            circumflexO,diaeresisO,graveO,circumflexU,
            graveU,diaeresisY,upperDiaeresisO,upperDiaeresisU,
            cent,pound,yen,ruble,florin,acuteA,acuteI,acuteO,
            acuteU,tildeN,upperTildeN,femenineA,masculineO,
            upsideDownQuestionMark,logicalNegateL,logicalNegateR,
            oneOverTwo,oneOverFour,upsideDownExclamation,
            doubleLeft,doubleRight,ditherLight,ditherMedium,
            ditherHard,vertical,vertLeft,vertDoubleLeft,
            doubleVertLeft,leftDoubleDown,doubleLeftDown,
            doubleVertDoubleLeft,doubleVert,doubleLeftDoubleDown,
            doubleLeftDoubleUp,leftDoubleUp,doubleLeftUp,
            leftDown,upRight,horizUp,horizDown,vertRight,
            horiz,vertHoriz,vertDoubleRight,doubleVertRight,
            doubleUpDoubleRight,doubleDownDoubleRight,
            doubleHorizDoubleUp,doubleHorizDoubleDown,
            doubleVertDoubleRight,doubleHoriz,
            doubleVertDoubleHoriz,doubleHorizUp,
            horizDoubleUp,doubleHorizDown,horizDoubleDown,
            DoubleUpRight,upDoubleRight,doubleDownRight,
            downDoubleRight,horizDoubleVert,vertDoubleHoriz,
            leftUp,downRight,square,bottomHalfSquare,
            leftHalfSquare,rightHalfSquare,topHalfSquare,
            alpha,ezset,gamma,pi,upperSigma,sigma,
            mu,tau,upperPhi,theta,omega,delta,infiniti,
            phi,epsilon,intersection,equivalent,plusminus,
            greatertOrEqual,lessOrEqual,ceil,floor,
            divide,approximate,degrees,bigDot,
            dot,squareRoot,superscript,squared,box,
            anotherBlank
        };
        public static List<char> rawChars = new List<char>
        {
            ' ','☺','☻','♥','♦','♣','♠','•','◘','○','◙','♂','♀','♪','♫','☼',
            '►','◄','↕','‼','¶','§','▬','↨','↑','↓','→','←','∟','↔','▲','▼',
            '¯','!','\"','#','$','%','&','\'','(',')','*','+',',','-','.','/',
            '0','1','2','3','4','5','6','7','8','9',':',';','<','=','>','?',
            '@','A','B','C','D','E','F','G','H','I','J','K','L','M','N','O',
            'P','Q','R','S','T','U','V','W','X','Y','Z','[','\\',']','^','_',
            '`','a','b','c','d','e','f','g','h','i','j','k','l','m','n','o',
            'p','q','r','s','t','u','v','w','x','y','z','{','∶','}','~','⌂',
            'Ç','ü','é','â','ä','à','å','ç','ê','ë','è','ï','î','ì','Ä','Å',
            'É','æ','Æ','ô','ö','ò','û','ù','ÿ','Ö','Ü','¢','£','￥','₽','ƒ',
            'á','í','ó','ú','ñ','Ñ','ª','º','¿','⌐','¬','½','¼','¡','«','»',
            '░','▒','▓','│','┤','╡','╢','╖','╕','╣','║','╗','╝','╜','╛','┐',
            '└','┴','┬','├','─','┼','╞','╟','╚','╔','╩','╦','╠','═','╬','╧',
            '╨','╤','╥','╙','╘','╒','╓','╫','╪','┘','┌','█','▄','▌','▐','▀',
            'α','ß','Γ','π','Σ','σ','µ','τ','Φ','Θ','Ω','δ','∞','φ','ε','∩',
            '≡','±','≥','≤','⌠','⌡','÷','≈','°','∙','·','√','ⁿ','²','■',' '
        };

        public static char pointToChar(Point input)
        {
            for (int i = 0; i < charRect.Count; i++)
            {
                if (new Rectangle(input.X, input.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y) == charRect[i])
                {
                    return rawChars[i];
                }
            }
            return '☺';
        }

        public static Rectangle rawChartoChar(char input)
        {
            for (int i = 0; i < rawChars.Count; i++)
            {
                if (input == rawChars[i])
                {
                    return charRect[i];
                }
            }
            return new Rectangle(0, 1, monogameClass.fontSize.X, monogameClass.fontSize.Y);
        }

        //  ╗ ╔ ╝ ╚ ║ ═ ╠ ╦ ╣ ╩ ╬ //easy to find boxchars

        //  ┐ ┌ ┘ └ │ ─ ├ ┬ ┤ ┴ ┼

        //  ╕ ╒ ╛ ╘ │ ═ ╞ ╤ ╡ ╧ ╪

        //  ╖ ╓ ╜ ╙ ║ ─ ╟ ╥ ╢ ╨ ╫
        
    }
}

