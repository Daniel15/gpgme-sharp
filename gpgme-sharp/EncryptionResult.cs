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
using System.Reflection;
using System.Runtime.InteropServices;
using Libgpgme.Interop;

namespace Libgpgme
{
    public class EncryptionResult
    {

        private InvalidKey invalid_recipients;
        public InvalidKey InvalidRecipients
        {
            get { return invalid_recipients; }
        }

        internal EncryptionResult(IntPtr rPtr)
        {
            if (rPtr == IntPtr.Zero)
                throw new InvalidPtrException("An invalid pointer for the encrypt_result structure has been supplied.");
            UpdateFromMem(rPtr);
        }

        private void UpdateFromMem(IntPtr rPtr)
        {
            _gpgme_op_encrypt_result rst = new _gpgme_op_encrypt_result();
            Marshal.PtrToStructure(rPtr, rst);

            if (rst.invalid_recipients != IntPtr.Zero)
                invalid_recipients = new InvalidKey(rst.invalid_recipients);
        }
    }
}
