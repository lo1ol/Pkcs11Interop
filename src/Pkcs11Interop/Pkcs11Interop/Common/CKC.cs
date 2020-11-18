﻿/*
 *  Copyright 2012-2019 The Pkcs11Interop Project
 *
 *  Licensed under the Apache License, Version 2.0 (the "License");
 *  you may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 *  Unless required by applicable law or agreed to in writing, software
 *  distributed under the License is distributed on an "AS IS" BASIS,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  See the License for the specific language governing permissions and
 *  limitations under the License.
 */

/*
 *  Written for the Pkcs11Interop project by:
 *  Jaroslav IMRICH <jimrich@jimrich.sk>
 */

namespace Net.Pkcs11Interop.Common
{
    /// <summary>
    /// Certificate types
    /// </summary>
    public enum CKC : uint
    {
        /// <summary>
        /// X.509 public key certificate
        /// </summary>
        CKC_X_509 = 0x00000000,

        /// <summary>
        /// X.509 attribute certificate
        /// </summary>
        CKC_X_509_ATTR_CERT = 0x00000001,

        /// <summary>
        /// WTLS public key certificate
        /// </summary>
        CKC_WTLS = 0x00000002,

        /// <summary>
        /// Permanently reserved for token vendors
        /// </summary>
        CKC_VENDOR_DEFINED = 0x80000000
    }
}