﻿/*
 * gpgme-sharp - .NET wrapper classes for libgpgme (GnuPG Made Easy)
 *  Copyright (C) 2008 Daniel Mueller <daniel@danm.de>
 *
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 2.1 of the License, or (at your option) any later version.
 *
 * This library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public
 * License along with this library; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301  USA
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Libgpgme
{
    public class PgpPassphraseOptions
    {
        internal static int MAX_PASSWD_COUNT = 4;

        // passphrase change
        internal bool passphraseSendCmd = false;
        internal bool needoldpw = true;
        
        internal bool missingpasswd = false;
        internal bool aborthandler = false;

        internal int emptypasswdcount = 0;

        public char[] OldPassphrase;
        public char[] NewPassphrase;
        public PassphraseDelegate OldPassphraseCallback;
        public PassphraseDelegate NewPassphraseCallback;
        public bool EmptyOkay = false;
    }
}
